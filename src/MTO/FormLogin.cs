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
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            User currUser = Program.db.Users.Where(p => p.Username == textBoxLogin.Text).First();

            if(currUser != null && currUser.Password == textBoxPassword.Text)
            {
                Program.user = currUser;

                this.Hide();

                formContracts = new FormContracts();
                formContracts.Closed += (s, args) => this.Close();

                formContracts.Show();
            }
            else
            {
                MessageBox.Show("Неверные входные данные!");
            }
        }
    }
}
