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
    public partial class FormWarehouses : Form
    {
        public FormWarehouses()
        {
            InitializeComponent();
        }

        private void FormWarehouses_Load(object sender, EventArgs e)
        {

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            FormWarehousesAdd form = new FormWarehousesAdd();
            form.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormWarehousesAdd form = new FormWarehousesAdd();
            form.ShowDialog();
        }
    }
}
