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
using MTO.Utils;

namespace MTO
{
    public partial class FormLogin : Form
    {
        private Form mainForm;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text == String.Empty)
            {
                MessageBox.Show("Введите логин!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(textBoxPassword.Text == String.Empty)
            {
                MessageBox.Show("Введите пароль!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User currUser = Program.db.Users
                .Where(p => p.Username == textBoxLogin.Text).FirstOrDefault();

            if (currUser != null && Hashing.ValidatePassword(textBoxPassword.Text, currUser.Password))

            {
                Program.user = currUser;

                this.Hide();

                if (Program.user.isAdmin() || Program.user.isContract())
                {

                    mainForm = new FormStartContract();
                    mainForm.Closed += (s, args) => this.Close();

                    mainForm.Show();
                }
                else if (Program.user.isAccounting())
                {
                    mainForm = new FormStartAccounting();
                    mainForm.Closed += (s, args) => this.Close();

                    mainForm.Show();
                }
                else
                    MessageBox.Show("Ошибка роли пользователя", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Неверные входные данные!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
