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
    public partial class FormContractView : Form
    {
        private Contract contract;
        private string dateFormat = "dd.MM.yyyy";
        private string header = "Договор поставки № ";
        private string templatePath = "..//..//..//static//contract.rtf";

        public FormContractView(Contract contract)
        {
            InitializeComponent();

            this.contract = contract;
        }

        private void FormContractView_Load(object sender, EventArgs e)
        {
            dgv_contractLines.AutoGenerateColumns = false;
            dgv_contractLines.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            lbl_header.Text = header + contract.ContractNumber;

            fillDocument();
            fillSpecification();
        }

        private void tsmi_editChange_Click(object sender, EventArgs e)
        {
            FormContractAdd form = new FormContractAdd(contract);
            form.ShowDialog();
        }

        private void fillSpecification()
        {
            List<ContractLine> contractLines = contract.getContractLines();
            dgv_contractLines.DataSource = contractLines;

            dgv_contractLines.Columns[0].DataPropertyName = "PK_ContractLine";
            dgv_contractLines.Columns[1].DataPropertyName = "Resource";
            dgv_contractLines.Columns[2].DataPropertyName = "Resource_Cipher";
            dgv_contractLines.Columns[3].DataPropertyName = "Amount";
            dgv_contractLines.Columns[4].DataPropertyName = "Resource_Unit";
            dgv_contractLines.Columns[5].DataPropertyName = "Resource_Unit_Cipher";
            dgv_contractLines.Columns[6].DataPropertyName = "UnitPrice";
            dgv_contractLines.Columns[7].DataPropertyName = "TotalPrice";
            dgv_contractLines.Columns[8].DataPropertyName = "DeliveryDate";
        }

        private void fillDocument()
        {
            Provider provider = contract.Provider;
            OrganizationDescription orgDesc = Program.db.OrganizationDescriptions.First();

            Dictionary<string, string> replace = new Dictionary<string, string>
            {
                {"[ConclusionCity]",  contract.ConclusionCity},
                {"[ConclusionDate]",  contract.ConclusionDate.ToString(dateFormat)},
                {"[ProviderName]",  provider.Name},
                {"[ProviderAgentRole]",  contract.ProviderAgentRole},
                {"[CustomerName]",  orgDesc.Name},
                {"[CustomerAgentRole]",  contract.CustomerAgentRole},
                {"[SupplierPenalty]",  contract.SupplierPenalty.ToString()},
                {"[CustomerPenalty]",  contract.CustomerPenalty.ToString()},
                {"[StartDate]",  contract.StartDate.ToString(dateFormat)},
                {"[ExpiredDate]",  contract.ExpiredDate.ToString(dateFormat)},
                {"[ProviderAddress]",  provider.Address},
                {"[ProviderINN]",  provider.INN},
                {"[ProviderPhoneNumber]",  provider.PhoneNumber},
                {"[ProviderCheckingAccount]",  provider.CheckingAccount},
                {"[ProviderCorrespondentAccount]",  provider.CorrespondentAccount},
                {"[ProviderBIK]",  provider.BIK},
                {"[ProviderAgentName]",  contract.ProviderAgentName},
                {"[CustomerAddress]",  orgDesc.Address},
                {"[CustomerINN]",  orgDesc.INN},
                {"[CustomerPhoneNumber]",  orgDesc.PhoneNumber},
                {"[CustomerCheckingAccount]",  orgDesc.CheckingAccount},
                {"[CustomerCorrespondentAccount]",  orgDesc.CorrespondentAccount},
                {"[CustomerBIK]",  orgDesc.BIK},
                {"[CustomerAgentName]",  contract.CustomerAgentName},
            };

            rtb_document.LoadFile(templatePath);

            foreach (KeyValuePair<string, string> keyValue in replace)
            {
                int found = 1;

                while (true)
                {
                    found = rtb_document.Find(keyValue.Key);

                    if (found == -1)
                        break;

                    rtb_document.SelectedText = rtb_document.SelectedText.Replace(keyValue.Key, keyValue.Value);
                }
            }
        }

        private void tsmi_editDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить данный договор?", "Подтвердите действие", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //удаляем запись
            if(result == DialogResult.Yes)
            {
                try
                {
                        if (contract != null)
                        {
                            Program.db.Contracts.Remove(contract);
                            Program.db.SaveChanges();
                        }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления, " + ex.ToString());
                }
            }
        }
    }
}
