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
    public partial class FormReceiptOrderView : Form
    {
        public FormReceiptOrderView()
        {
            InitializeComponent();
        }

        private void tsmi_editChange_Click(object sender, EventArgs e)
        {
            FormReceiptOrderAdd form = new FormReceiptOrderAdd();
            form.ShowDialog();
        }
    }
}
