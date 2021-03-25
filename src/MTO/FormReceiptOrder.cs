using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTO
{
    public partial class FormReceiptOrder : Form
    {
        public FormReceiptOrder()
        {
            InitializeComponent();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dateTimePicker3.CustomFormat = " ";
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

        private void tsmi_accountingReceiptOrderAdd_Click(object sender, EventArgs e)
        {
            FormReceiptOrderAdd form = new FormReceiptOrderAdd();
            form.ShowDialog();
        }

        private void FormReceiptOrder_Load(object sender, EventArgs e)
        {
            dgv_receiptOrders.Rows.Add();
            dgv_receiptOrders[0, 0].Value = "000001";
            dgv_receiptOrders[1, 0].Value = "24/03/2020";
            dgv_receiptOrders[2, 0].Value = "001";
            dgv_receiptOrders[3, 0].Value = "ООО Фисташка";
            dgv_receiptOrders[4, 0].Value = "123154";
        }

        private void btn_viewReceiptOrder_Click(object sender, EventArgs e)
        {
            FormReceiptOrderView form = new FormReceiptOrderView();
            form.ShowDialog();
        }
    }
}
