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
            dtp_expiredDate.CustomFormat = "dd-MM-yyyy";
        }

        private void dtp_startDate_ValueChanged(object sender, EventArgs e)
        {
            dtp_startDate.CustomFormat = "dd-MM-yyyy";
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
                dtp_expiredDate.CustomFormat = " ";
            }
        }

        private void dtp_startDate_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtp_startDate.CustomFormat = " ";
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
            }
        }

        private void btn_analizeContract_Click(object sender, EventArgs e)
        {
            FormAnalysis form = new FormAnalysis();
            form.ShowDialog();
        }

        public void tsmi_contractCreate_Click(object sender, EventArgs e)
        {
            FormContractAdd form = new FormContractAdd();
            form.ShowDialog();
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
            cb_provider.SelectedIndex = -1;
            dtp_conclusionDate.CustomFormat = " ";
            dtp_expiredDate.CustomFormat = " ";
            dtp_startDate.CustomFormat = " ";
            rb_any.Checked = true;

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
            dgv_contracts.Columns[6].DataPropertyName = "Status";
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

            bool conclusionCriterium = dtp_conclusionDate.CustomFormat.ToString() != " ";
            string conclusionDate = dtp_conclusionDate.Value.ToString("dd-MM-yyyy");

            bool startCriterium = dtp_startDate.CustomFormat.ToString() != " ";
            string startDate = dtp_startDate.Value.ToString("dd-MM-yyyy");

            bool expiredCriterium = dtp_expiredDate.CustomFormat.ToString() != " ";
            string expiredDate = dtp_expiredDate.Value.ToString("dd-MM-yyyy");

            bool statusCriterium = !rb_any.Checked;

            foreach (Contract contract in Program.db.Contracts)
            {
                bool contractNumberFound = !contractNumberCriterium;
                bool providerFound = !providerCriterium;
                bool conclusionFound = !conclusionCriterium;
                bool startFound = !startCriterium;
                bool expiredFound = !expiredCriterium;
                bool statusFound = !statusCriterium;

                if (contractNumberCriterium && contract.ContractNumber.Contains(contractNumber))
                    contractNumberFound = true;

                if (providerCriterium && contract.Provider.PK_Provider == PK_Provider)
                    providerFound = true;

                if (conclusionCriterium && contract.ConclusionDateWithoutTime.Contains(conclusionDate))
                    conclusionFound = true;

                if (startCriterium && contract.StartDateWithoutTime.Contains(startDate))
                    startFound = true;

                if (expiredCriterium && contract.ExpiredDateWithoutTime.Contains(expiredDate))
                    expiredFound = true;

                if (statusCriterium && (contract.IsOpened && rb_opened.Checked) || (!contract.IsOpened && rb_closed.Checked))
                        statusFound = true;

                if (contractNumberFound && providerFound && conclusionFound && 
                    startFound && expiredFound && statusFound)
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
