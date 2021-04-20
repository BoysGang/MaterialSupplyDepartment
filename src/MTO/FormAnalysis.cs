using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


            lines = contract.getContractLines();
            int linesCount = lines.Count;
            ContractLine line;

            for (int i = 0; i < linesCount; i++)
            {
                dgv_analysis.Rows.Add();

                line = lines[i];

                dgv_analysis.Rows[i].Cells[0].Value = line.PK_ContractLine;
                dgv_analysis.Rows[i].Cells[1].Value = line.Resource;
                dgv_analysis.Rows[i].Cells[2].Value = line.Resource_Cipher;
                dgv_analysis.Rows[i].Cells[3].Value = line.Resource_Unit;
                dgv_analysis.Rows[i].Cells[4].Value = line.Resource_Cipher;
                dgv_analysis.Rows[i].Cells[5].Value = line.DeliveryDate.ToString("dd-MM-yyyy");
                dgv_analysis.Rows[i].Cells[6].Value = "";
                dgv_analysis.Rows[i].Cells[7].Value = line.Amount;
                dgv_analysis.Rows[i].Cells[8].Value = "";
                dgv_analysis.Rows[i].Cells[9].Value = "";
                dgv_analysis.Rows[i].Cells[10].Value = line.UnitPrice;
                dgv_analysis.Rows[i].Cells[11].Value = "";
            }


        }

        private void FormAnalysis_Load(object sender, EventArgs e)
        {
            dgv_analysis.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
