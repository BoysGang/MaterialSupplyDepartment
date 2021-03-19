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
    public partial class FormContractView : Form
    {
        public FormContractView()
        {
            InitializeComponent();
        }

        private void FormContractView_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("check.rtf");
            richTextBox1.Find("[1]");
            richTextBox1.SelectedText = richTextBox1.SelectedText.Replace("[1]", "Барнаул");

            richTextBox1.Find("[2]");
            richTextBox1.SelectedText = richTextBox1.SelectedText.Replace("[2]", "21.02.2009");
        }
    }
}
