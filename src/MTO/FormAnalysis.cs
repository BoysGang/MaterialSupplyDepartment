using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using MTO.Models;

namespace MTO
{
    public partial class FormAnalysis : Form
    {
        private Contract contract;
        private List<ContractLine> lines;
        public FormAnalysis(Contract contract)
        {
            InitializeComponent();

            this.contract = contract;

            lbl_header.Text = "Анализ поставок по договору №"
                + contract.ContractNumber + " от "
                + contract.ConclusionDate.ToString("dd.MM.yyyy") + " ("
                + (contract.IsOpened ? "ОТКРЫТ)" : "ЗАКРЫТ)");

            int pk_contract = contract.PK_Contract;
            lines = contract.getContractLines();
            List<ReceiptOrderLine> receiptLines = Program.db.ReceiptOrderLines.ToList()
                                            .Where(b => b.ReceiptOrder.PK_Contract == pk_contract)
                                            .OrderBy(b => b.ReceiptOrder.DeliveryDate)
                                            .ToList();

            int linesCount = lines.Count;
            ContractLine line;

            for (int i = 0; i < linesCount; i++)
            {
                dgv_analysis.Rows.Add();

                line = lines[i];

                ReceiptOrderLine thisLine = receiptLines.FindAll(b => b.PK_Resource == line.PK_Resource)
                    .Where(b => b.ReceiptOrder.DeliveryDate <= line.DeliveryDate)
                    .FirstOrDefault();

                if(thisLine != null)
                {
                    DateTime dateFact = thisLine.ReceiptOrder.DeliveryDate;
                    float amountFact = thisLine.AcceptedAmount;


                    dgv_analysis.Rows[i].Cells[6].Value = dateFact.ToString("dd-MM-yyyy");
                    dgv_analysis.Rows[i].Cells[8].Value = thisLine == null ? "0" : thisLine.AcceptedAmount.ToString();
                    dgv_analysis.Rows[i].Cells[9].Value = line.Amount - thisLine.AcceptedAmount;
                    dgv_analysis.Rows[i].Cells[11].Value = line.UnitPrice * (decimal)(line.Amount - thisLine.AcceptedAmount);

                    receiptLines.Remove(thisLine);
                }
                else
                {
                    dgv_analysis.Rows[i].Cells[6].Value = "-";
                    dgv_analysis.Rows[i].Cells[8].Value = 0;
                    dgv_analysis.Rows[i].Cells[9].Value = line.Amount;
                    dgv_analysis.Rows[i].Cells[11].Value = (decimal)line.Amount * line.UnitPrice;

                }

                dgv_analysis.Rows[i].Cells[0].Value = line.PK_ContractLine;
                dgv_analysis.Rows[i].Cells[1].Value = line.Resource;
                dgv_analysis.Rows[i].Cells[2].Value = line.Resource_Cipher;
                dgv_analysis.Rows[i].Cells[3].Value = line.Resource_Unit;
                dgv_analysis.Rows[i].Cells[4].Value = line.Resource_Cipher;
                dgv_analysis.Rows[i].Cells[5].Value = line.DeliveryDate.ToString("dd-MM-yyyy");
                dgv_analysis.Rows[i].Cells[7].Value = line.Amount;
                dgv_analysis.Rows[i].Cells[10].Value = line.UnitPrice;


                float amountUnderdelivery = 0;
                if (float.TryParse(dgv_analysis.Rows[i].Cells[9].Value.ToString(),
                    System.Globalization.NumberStyles.Float,
                    CultureInfo.InvariantCulture,
                    out amountUnderdelivery))
                {
                    if (amountUnderdelivery < 0)
                    {
                        dgv_analysis.Rows[i].Cells[9].Value = "Отсутствуют";
                        dgv_analysis.Rows[i].Cells[11].Value = "-";
                    }
                }
            }
        }

        private void FormAnalysis_Load(object sender, EventArgs e)
        {
            dgv_analysis.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

    }
}
