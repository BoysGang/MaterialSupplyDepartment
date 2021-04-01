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
    public partial class FormLogin : Form
    {
        private FormContracts formContracts;

        public FormLogin()
        {
            InitializeComponent();

            Unit unit = new Unit() { Name = "Artyom", Cipher = "123" };

            Program.db.Add(unit);
            Program.db.SaveChanges();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            formContracts = new FormContracts();
            formContracts.Closed += (s, args) => this.Close();

            formContracts.Show();
        }
    }
}
