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
    public partial class FormContracts : Form
    {
        public FormContracts()
        {
            InitializeComponent();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dateTimePicker3.CustomFormat = " ";
            }
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dateTimePicker2.CustomFormat = " ";
            }
        }

        private void FormContracts_Load(object sender, EventArgs e)
        {
            dgv_contracts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgv_contracts.Rows.Add();
            dgv_contracts[0, 0].Value = "000001";
            dgv_contracts[1, 0].Value = "24/03/2020";
            dgv_contracts[2, 0].Value = "24/03/2021";
            dgv_contracts[3, 0].Value = "ООО Фисташка";
            dgv_contracts[4, 0].Value = "Открыт";
            dgv_contracts[5, 0].Value = "Есть";

        }

        private void btn_viewContract_Click(object sender, EventArgs e)
        {
            FormContractView formContractView = new FormContractView();
            formContractView.ShowDialog();
        }

        private void btn_analizeContract_Click(object sender, EventArgs e)
        {
            FormAnalysis form = new FormAnalysis();
            form.ShowDialog();
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
    }
}
