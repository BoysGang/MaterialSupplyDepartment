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
    public partial class FormProviders : Form
    {
        public FormProviders()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormProvidersAdd form = new FormProvidersAdd();
            form.ShowDialog();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            FormProvidersAdd form = new FormProvidersAdd();
            form.ShowDialog();
        }
    }
}
