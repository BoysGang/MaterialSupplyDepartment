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
            dataGridView1.Rows.Add();
            dataGridView1[0, 0].Value = "000001";
            dataGridView1[1, 0].Value = "24/03/2020";
            dataGridView1[2, 0].Value = "24/03/2021";
            dataGridView1[3, 0].Value = "ООО Фисташка";
            dataGridView1[4, 0].Value = "Открыт";
            dataGridView1[5, 0].Value = "Есть";

        }
    }
}
