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
    public partial class FormReceiptOrder : Form
    {
        private List<ReceiptOrder> receiptOrders;

        public FormReceiptOrder()
        {
            InitializeComponent();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dtp_deliveryDateFrom.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtp_deliveryDateFrom.CustomFormat = " ";
            }
        }

        private void dtp_deliveryDateTo_ValueChanged(object sender, EventArgs e)
        {
            dtp_deliveryDateTo.CustomFormat = "dd/MM/yyyy";
        }

        private void dtp_deliveryDateTo_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtp_deliveryDateTo.CustomFormat = " ";
            }
        }

        private void tsmi_ContractSearch_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormContracts form = new FormContracts();
            form.Closed += (s, args) => this.Close();

            form.Show();
        }

        private void tsmi_contractCreate_Click(object sender, EventArgs e)
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

        public void tsmi_accountingReceiptOrderAdd_Click(object sender, EventArgs e)
        {
            FormReceiptOrderAdd form = new FormReceiptOrderAdd();
            form.ShowDialog();

            updateReceiptOrderTable();
        }

        private void FormReceiptOrder_Load(object sender, EventArgs e)
        {
            dgv_receiptOrders.AutoGenerateColumns = false;
            dgv_receiptOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            List<Warehouse> warehouses = Program.db.Warehouses.ToList();
            cb_warehouse.DataSource = warehouses;
            cb_warehouse.SelectedIndex = -1;

            List<Provider> providers = Program.db.Providers.ToList();
            cb_provider.DataSource = providers;
            cb_provider.SelectedIndex = -1;

            List<Resource> resources = Program.db.Resources.ToList();
            cb_resource.DataSource = resources;
            cb_resource.SelectedIndex = -1;

            List<ReceiptOrder> receiptOrders = Program.db.ReceiptOrders.ToList();
            AutoCompleteStringCollection ordersSource = new AutoCompleteStringCollection();
            foreach (ReceiptOrder order in receiptOrders)
                ordersSource.Add(order.ReceiptOrderNumber);
            tb_receiptOrderNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb_receiptOrderNumber.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_receiptOrderNumber.AutoCompleteCustomSource = ordersSource;

            List<Contract> contracts = Program.db.Contracts.ToList();
            AutoCompleteStringCollection contractsSource = new AutoCompleteStringCollection();
            foreach (Contract contract in contracts)
                contractsSource.Add(contract.ContractNumber);
            tb_contractNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb_contractNumber.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_contractNumber.AutoCompleteCustomSource = contractsSource;

            if (Program.user.isAccounting())
            {
                tsmi_contracts.Visible = false;
            }

            this.receiptOrders = receiptOrders;

            updateReceiptOrderTable();
        }

        private void btn_viewReceiptOrder_Click(object sender, EventArgs e)
        {
            ReceiptOrder viewingReceiptOrder = getSelectedReceiptOrder();

            if (viewingReceiptOrder != null)
            {
                FormReceiptOrderView form = new FormReceiptOrderView(viewingReceiptOrder);
                form.ShowDialog();

                updateReceiptOrderTable();

            }
        }

        private void updateReceiptOrderTable()
        {
            findReceiptOrders();

            dgv_receiptOrders.DataSource = receiptOrders;

            dgv_receiptOrders.Columns[0].DataPropertyName = "PK_ReceiptOrder";
            dgv_receiptOrders.Columns[1].DataPropertyName = "ReceiptOrderNumber";
            dgv_receiptOrders.Columns[2].DataPropertyName = "DeliveryDateWithoutTime";
            dgv_receiptOrders.Columns[3].DataPropertyName = "Warehouse";
            dgv_receiptOrders.Columns[4].DataPropertyName = "Provider";
            dgv_receiptOrders.Columns[5].DataPropertyName = "Contract";
        }

        private void dgv_receiptOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_receiptOrders.SelectedRows != null)
            {
                btn_viewReceiptOrder.Enabled = true;
            }
            else
            {
                btn_viewReceiptOrder.Enabled = false;
            }
        }

        private ReceiptOrder getSelectedReceiptOrder()
        {
            int PK_ReceiptOrder = Convert.ToInt32(dgv_receiptOrders.SelectedRows[0].Cells[0].Value);

            return Program.db.ReceiptOrders.Find(PK_ReceiptOrder);
        }

        private void tb_receiptOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ModifierKeys.HasFlag(Keys.Control))
                e.Handled = !TextValidator.isNumber(e.KeyChar.ToString());
        }

        private void tb_contract_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ModifierKeys.HasFlag(Keys.Control))
                e.Handled = !TextValidator.isNumber(e.KeyChar.ToString());
        }

        private void btn_resetSearch_Click(object sender, EventArgs e)
        {
            tb_receiptOrderNumber.Text = "";
            cb_provider.SelectedIndex = -1;
            dtp_deliveryDateFrom.CustomFormat = " ";
            dtp_deliveryDateTo.CustomFormat = " ";
            cb_warehouse.SelectedIndex = -1;
            cb_resource.SelectedIndex = -1;

            updateReceiptOrderTable();
        }

        private void btn_findReceiptOrder_Click(object sender, EventArgs e)
        {
            updateReceiptOrderTable();
        }

        private void findReceiptOrders()
        {
            List<ReceiptOrder> foundReceiptOrders = new List<ReceiptOrder>();

            bool orderNumberCriterium = tb_receiptOrderNumber.Text != string.Empty;
            string orderNumber = tb_receiptOrderNumber.Text.ToLower();

            Provider provider = (Provider)cb_provider.SelectedItem;
            bool providerCriterium = false;
            int PK_Provider = -1;
            if (provider != null)
            {
                providerCriterium = true;
                PK_Provider = provider.PK_Provider;
            }

            bool deliveryFromCriterium = dtp_deliveryDateFrom.CustomFormat.ToString() != " ";
            DateTime deliveryFromDate = DateTime.Parse(dtp_deliveryDateFrom.Value.ToString("dd-MM-yyyy"));

            bool deliveryToCriterium = dtp_deliveryDateTo.CustomFormat.ToString() != " ";
            DateTime deliveryToDate = DateTime.Parse(dtp_deliveryDateTo.Value.ToString("dd-MM-yyyy"));

            Warehouse warehouse = (Warehouse)cb_warehouse.SelectedItem;
            bool warehouseCriterium = false;
            int PK_Warehouse = -1;
            if (warehouse != null)
            {
                warehouseCriterium = true;
                PK_Warehouse = warehouse.PK_Warehouse;
            }

            Resource resourceSelect = (Resource)cb_resource.SelectedItem;
            bool resourceCriterium = false;
            if (resourceSelect != null)
            {
                resourceCriterium = true;
            }

            bool contractNumberCriterium = tb_contractNumber.Text != string.Empty;
            string contractNumber = tb_contractNumber.Text.ToLower();

            foreach (ReceiptOrder order in Program.db.ReceiptOrders.ToList())
            {
                bool orderNumberFound = !orderNumberCriterium;
                bool providerFound = !providerCriterium;
                bool deliveryFromFound = !deliveryFromCriterium;
                bool deliveryToFound = !deliveryToCriterium;
                bool warehouseFound = !warehouseCriterium;
                bool resourceFound = !resourceCriterium;
                bool contractFound = !contractNumberCriterium;

                if (orderNumberCriterium && order.ReceiptOrderNumber.Contains(orderNumber))
                    orderNumberFound = true;

                if (providerCriterium && order.Provider.PK_Provider == PK_Provider)
                    providerFound = true;

                if (deliveryFromCriterium && DateTime.Compare(order.DeliveryDate, deliveryFromDate) >= 0)
                    deliveryFromFound = true;

                if (deliveryToCriterium && DateTime.Compare(order.DeliveryDate, deliveryToDate) <= 0)
                    deliveryToFound = true;

                if (warehouseCriterium && order.Warehouse.PK_Warehouse == PK_Warehouse)
                    warehouseFound = true;

                if (resourceCriterium && order.checkResourceInReceiptOrder(resourceSelect))
                    resourceFound = true;

                if (contractNumberCriterium && order.Contract.ContractNumber.Contains(contractNumber))
                    contractFound = true;

                if (orderNumberFound && providerFound && deliveryFromFound && deliveryToFound &&
                    warehouseFound && resourceFound && contractFound)
                    foundReceiptOrders.Add(order);
            }

            receiptOrders = foundReceiptOrders;
        }
    }
}
