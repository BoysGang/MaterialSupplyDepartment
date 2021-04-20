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
using MTO.Utils;

namespace MTO
{
    public partial class FormContracts : Form
    {
        private List<Contract> contracts;

        public FormContracts()
        {
            InitializeComponent();
        }

        private void dtp_conclusionDate_ValueChanged(object sender, EventArgs e)
        {
            dtp_conclusionDate.CustomFormat = "dd-MM-yyyy";
        }

        private void dtp_expiredDate_ValueChanged(object sender, EventArgs e)
        {
            dtp_expiredDateFrom.CustomFormat = "dd-MM-yyyy";
        }

        private void dtp_startDate_ValueChanged(object sender, EventArgs e)
        {
            dtp_startDateFrom.CustomFormat = "dd-MM-yyyy";
        }

        private void dtp_startDateTo_ValueChanged(object sender, EventArgs e)
        {
            dtp_startDateTo.CustomFormat = "dd-MM-yyyy";
        }

        private void dtp_expiredDateTo_ValueChanged(object sender, EventArgs e)
        {
            dtp_expiredDateTo.CustomFormat = "dd-MM-yyyy";
        }

        private void dtp_conclusionDate_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtp_conclusionDate.CustomFormat = " ";
            }
        }

        private void dtp_expiredDate_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtp_expiredDateFrom.CustomFormat = " ";
            }
        }

        private void dtp_startDate_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtp_startDateFrom.CustomFormat = " ";
            }
        }

        private void dtp_startDateTo_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtp_startDateTo.CustomFormat = " ";
            }
        }

        private void dtp_expiredDateTo_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtp_expiredDateTo.CustomFormat = " ";
            }
        }

        private void FormContracts_Load(object sender, EventArgs e)
        {
            dgv_contracts.AutoGenerateColumns = false;
            dgv_contracts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            List<Contract> contracts = Program.db.Contracts.ToList();

            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            foreach (Contract contract in contracts)
                source.Add(contract.ContractNumber);

            tb_contractNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb_contractNumber.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_contractNumber.AutoCompleteCustomSource = source;

            List<Provider> providers = Program.db.Providers.ToList();
            cb_provider.DataSource = providers;
            cb_provider.SelectedIndex = -1;

            List<Resource> resources = Program.db.Resources.ToList();
            cb_resource.DataSource = resources;
            cb_resource.SelectedIndex = -1;

            if (Program.user.isContract())
            {
                tsmi_accounting.Visible = false;
            }

            this.contracts = contracts;

            updateContractTable();
        }

        private void btn_viewContract_Click(object sender, EventArgs e)
        {
            int PK_Contract = Convert.ToInt32(dgv_contracts.SelectedRows[0].Cells[0].Value);
            Contract viewingContract = Program.db.Contracts.Find(PK_Contract);

            if (viewingContract != null)
            {
                FormContractView formContractView = new FormContractView(viewingContract);
                formContractView.ShowDialog();
                updateContractTable();
            }
        }

        private void btn_analizeContract_Click(object sender, EventArgs e)
        {
            if (dgv_contracts.CurrentCell != null)
            {
                int pk_contract = Convert.ToInt32(dgv_contracts.SelectedRows[0].Cells[0].Value);
                Contract currContract = Program.db.Contracts.Find(pk_contract);

                if (currContract != null)
                {
                    FormAnalysis form = new FormAnalysis(currContract);

                    form.ShowDialog();
                }
            }
            updateContractTable();
        }

        public void tsmi_contractCreate_Click(object sender, EventArgs e)
        {
            FormContractAdd form = new FormContractAdd();
            form.ShowDialog();
            updateContractTable();
        }

        private void tsmi_dictResources_Click(object sender, EventArgs e)
        {
            FormResources form = new FormResources();
            form.ShowDialog();
        }

        private void tsmi_dictUnit_Click(object sender, EventArgs e)
        {
            FormUnit form = new FormUnit();
            form.ShowDialog();
        }

        private void tsmi_dictProvider_Click(object sender, EventArgs e)
        {
            FormProviders form = new FormProviders();
            form.ShowDialog();
        }

        private void tsmi_dictWarehouses_Click(object sender, EventArgs e)
        {
            FormWarehouses form = new FormWarehouses();
            form.ShowDialog();
        }

        private void tsmi_accountingReceiptOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormReceiptOrder form = new FormReceiptOrder();
            form.Closed += (s, args) => this.Close();

            form.Show();
        }

        private void tsmi_accountingReceiptOrderAdd_Click(object sender, EventArgs e)
        {
            FormReceiptOrderAdd form = new FormReceiptOrderAdd();
            form.ShowDialog();
        }

        private void btn_resetSearch_Click(object sender, EventArgs e)
        {
            tb_contractNumber.Text = "";
            tb_conclusionCity.Text = "";
            cb_resource.SelectedIndex = -1;
            cb_provider.SelectedIndex = -1;
            dtp_conclusionDate.CustomFormat = " ";
            dtp_expiredDateFrom.CustomFormat = " ";
            dtp_startDateFrom.CustomFormat = " ";
            dtp_expiredDateTo.CustomFormat = " ";
            dtp_startDateTo.CustomFormat = " ";
            rb_any.Checked = true;
            cb_hasUnderdelivery.Checked = false;

            updateContractTable();
        }

        private void updateContractTable()
        {
            findContracts();

            dgv_contracts.DataSource = contracts;

            dgv_contracts.Columns[0].DataPropertyName = "PK_Contract";
            dgv_contracts.Columns[1].DataPropertyName = "ContractNumber";
            dgv_contracts.Columns[2].DataPropertyName = "ConclusionDateWithoutTime";
            dgv_contracts.Columns[3].DataPropertyName = "StartDateWithoutTime";
            dgv_contracts.Columns[4].DataPropertyName = "ExpiredDateWithoutTime";
            dgv_contracts.Columns[5].DataPropertyName = "Provider";
            dgv_contracts.Columns[6].DataPropertyName = "ConclusionCity";
            dgv_contracts.Columns[7].DataPropertyName = "Status";
        }

        private void dgv_contracts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_contracts.SelectedRows != null)
            {
                btn_viewContract.Enabled = true;
            }
            else
            {
                btn_viewContract.Enabled = false;
            }
        }

        private void btn_findContracts_Click(object sender, EventArgs e)
        {
            updateContractTable();
        }

        private void findContracts()
        {
            List<Contract> foundContracts = new List<Contract>();

            bool contractNumberCriterium = tb_contractNumber.Text != string.Empty;
            string contractNumber = tb_contractNumber.Text.ToLower();

            Provider providerSelect = (Provider)cb_provider.SelectedItem;
            bool providerCriterium = false;
            int PK_Provider = -1;
            if (providerSelect != null)
            {
                providerCriterium = true;
                PK_Provider = providerSelect.PK_Provider;
            }

            Resource resourceSelect = (Resource)cb_resource.SelectedItem;
            bool resourceCriterium = false;
            if (resourceSelect != null)
            {
                resourceCriterium = true;
            }

            bool conclusionCityCriterium = tb_conclusionCity.Text != "";
            string conclusionCity = tb_conclusionCity.Text;

            bool conclusionCriterium = dtp_conclusionDate.CustomFormat.ToString() != " ";
            string conclusionDate = dtp_conclusionDate.Value.ToString("dd-MM-yyyy");

            bool startFromCriterium = dtp_startDateFrom.CustomFormat.ToString() != " ";
            DateTime startFromDate = DateTime.Parse(dtp_startDateFrom.Value.ToString("dd-MM-yyyy"));

            bool expiredFromCriterium = dtp_expiredDateFrom.CustomFormat.ToString() != " ";
            DateTime expiredFromDate = DateTime.Parse(dtp_expiredDateFrom.Value.ToString("dd-MM-yyyy"));

            bool startToCriterium = dtp_startDateTo.CustomFormat.ToString() != " ";
            DateTime startToDate = DateTime.Parse(dtp_startDateTo.Value.ToString("dd-MM-yyyy"));

            bool expiredToCriterium = dtp_expiredDateTo.CustomFormat.ToString() != " ";
            DateTime expiredToDate = DateTime.Parse(dtp_expiredDateTo.Value.ToString("dd-MM-yyyy"));

            bool statusCriterium = !rb_any.Checked;

            bool hasUnderdeliveryCriterium = cb_hasUnderdelivery.Checked;

            foreach (Contract contract in Program.db.Contracts.ToList())
            {
                bool contractNumberFound = !contractNumberCriterium;
                bool providerFound = !providerCriterium;
                bool resourceFound = !resourceCriterium;
                bool conclusionCityFound = !conclusionCityCriterium;
                bool conclusionFound = !conclusionCriterium;
                bool startFromFound = !startFromCriterium;
                bool expiredFromFound = !expiredFromCriterium;
                bool startToFound = !startToCriterium;
                bool expiredToFound = !expiredToCriterium;
                bool statusFound = !statusCriterium;
                bool hasUnderdeliveryFound = !hasUnderdeliveryCriterium;

                // ContractNumber criterium
                if (contractNumberCriterium && contract.ContractNumber.Contains(contractNumber))
                    contractNumberFound = true;

                // Provider criterium
                if (providerCriterium && contract.Provider.PK_Provider == PK_Provider)
                    providerFound = true;

                // Resource criterium
                if (resourceCriterium && contract.checkResourceInContract(resourceSelect))
                    resourceFound = true;

                // ConclusionCity criterium
                if (conclusionCityCriterium && contract.ConclusionCity.Contains(conclusionCity))
                    conclusionCityFound = true;

                // Conclusion criterium
                if (conclusionCriterium && contract.ConclusionDateWithoutTime.Contains(conclusionDate))
                    conclusionFound = true;

                // Start criterium
                if (startFromCriterium && DateTime.Compare(contract.StartDate, startFromDate) >= 0)
                    startFromFound = true;

                if (startToCriterium && DateTime.Compare(contract.StartDate, startToDate) <= 0)
                    startToFound = true;

                // Expired criterium
                if (expiredFromCriterium && DateTime.Compare(contract.ExpiredDate, expiredFromDate) >= 0)
                    expiredFromFound = true;

                if (expiredToCriterium && DateTime.Compare(contract.ExpiredDate, expiredToDate) <= 0)
                    expiredToFound = true;

                // Status criterium
                if (statusCriterium && (contract.IsOpened && rb_opened.Checked) || (!contract.IsOpened && rb_closed.Checked))
                    statusFound = true;


                // Hasundetdelivery criterium
                if (hasUnderdeliveryCriterium)
                {
                    List<ContractLine> contractLines = contract.getContractLines();

                    List<ReceiptOrderLine> receiptLines = Program.db.ReceiptOrderLines.ToList()
                                .Where(b => b.ReceiptOrder.PK_Contract == contract.PK_Contract)
                                .OrderBy(b => b.ReceiptOrder.DeliveryDate)
                                .ToList();

                    for (int i = 0; i < contractLines.Count; i++)
                    {
                        ContractLine line = contractLines[i];

                        ReceiptOrderLine thisLine = receiptLines.FindAll(b => b.PK_Resource == line.PK_Resource)
                                                    .Where(b => b.ReceiptOrder.DeliveryDate <= line.DeliveryDate)
                                                    .FirstOrDefault();

                        if (thisLine == null)
                        {
                            hasUnderdeliveryFound = true;

                            break;
                        }
                        else
                        {
                            if (line.Amount - thisLine.AcceptedAmount > 0)
                            {
                                hasUnderdeliveryFound = true;

                                break;
                            }
                        }
                    }
                }

                // Add this contract to foundContracts if it passed all criteriums
                if (contractNumberFound && providerFound && conclusionFound &&
                    startFromFound && expiredFromFound && statusFound && startToFound && expiredToFound && conclusionCityFound && resourceFound && hasUnderdeliveryFound)
                    foundContracts.Add(contract);
            }

            contracts = foundContracts;
        }

        private void tb_contractNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ModifierKeys.HasFlag(Keys.Control))
                e.Handled = !TextValidator.isNumber(e.KeyChar.ToString());
        }
    }
}
