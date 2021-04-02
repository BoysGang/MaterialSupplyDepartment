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
    public partial class FormProvidersAdd : Form
    {
        private Provider editingProvider = null;

        public FormProvidersAdd(Provider editingProvider = null)
        {
            InitializeComponent();

            if (editingProvider != null)
            {
                this.Text = "Редактирование поставщика";

                tb_address.Text = editingProvider.Address;
                tb_BIK.Text = editingProvider.BIK;
                tb_checkingAccount.Text = editingProvider.CheckingAccount;
                tb_correspondentAccount.Text = editingProvider.CorrespondentAccount;
                tb_INN.Text = editingProvider.INN;
                tb_name.Text = editingProvider.Name;
                tb_phoneNumber.Text = editingProvider.PhoneNumber;

                btn_add.Text = "Изменить";

                this.editingProvider = editingProvider;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (editingProvider != null)
            {
                editingProvider.Address = tb_address.Text;
                editingProvider.BIK = tb_BIK.Text;
                editingProvider.CheckingAccount = tb_checkingAccount.Text;
                editingProvider.CorrespondentAccount = tb_correspondentAccount.Text;
                editingProvider.INN = tb_INN.Text;
                editingProvider.Name = tb_name.Text;
                editingProvider.PhoneNumber = tb_phoneNumber.Text;

                Program.db.Providers.Update(editingProvider);
            }
            else
            {
                Provider newProvider = new Provider()
                {
                    Address = tb_address.Text,
                    BIK = tb_BIK.Text,
                    CheckingAccount = tb_checkingAccount.Text,
                    CorrespondentAccount = tb_correspondentAccount.Text,
                    INN = tb_INN.Text,
                    Name = tb_name.Text,
                    PhoneNumber = tb_phoneNumber.Text,
                };

                Program.db.Providers.Add(newProvider);
            }

            Program.db.SaveChanges();
            this.Close();
        }
    }
}
