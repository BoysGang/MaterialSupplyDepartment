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
    public partial class FormStartAccounting : Form
    {

        public FormStartAccounting()
        {
            InitializeComponent();
        }

        private void btn_viewReceiptOrders_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormReceiptOrder form = new FormReceiptOrder();
            form.Closed += (s, args) => this.Close();

            form.Show();
        }

        private void btn_addReceiptOrder_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormReceiptOrder form = new FormReceiptOrder();
            form.Closed += (s, args) => this.Close();

            form.Show();

            form.tsmi_accountingReceiptOrderAdd_Click(sender, e);
        }
    }
}
