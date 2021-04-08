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

namespace MTO
{
    public partial class FormContractView : Form
    {
        Contract contract;

        public FormContractView(Contract contract)
        {
            InitializeComponent();

            this.contract = contract;
        }

        private void FormContractView_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("..//..//..//static//check.rtf");
            richTextBox1.Find("[1]");
            richTextBox1.SelectedText = richTextBox1.SelectedText.Replace("[1]", "Барнаул");

            richTextBox1.Find("[2]");
            richTextBox1.SelectedText = richTextBox1.SelectedText.Replace("[2]", "21.02.2009");
        }

        private void tsmi_editChange_Click(object sender, EventArgs e)
        {
            FormContractAdd form = new FormContractAdd(contract);
            form.ShowDialog();
        }
    }
}
