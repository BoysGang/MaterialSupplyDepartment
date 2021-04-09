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
    public partial class FormStartContract : Form
    {
        public FormStartContract()
        {
            InitializeComponent();
        }

        private void btn_viewContracts_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormContracts form = new FormContracts();
            form.Closed += (s, args) => this.Close();

            form.Show();
        }

        private void btn_addContract_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormContracts form = new FormContracts();
            form.Closed += (s, args) => this.Close();

            form.Show();

            form.tsmi_contractCreate_Click(sender, e);
        }
    }
}
