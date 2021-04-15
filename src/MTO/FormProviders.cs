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
    public partial class FormProviders : Form
    {
        private bool isReadOnly = false;

        List<Provider> providers;

        public FormProviders()
        {
            InitializeComponent();
        }

        private void FormProviders_Load(object sender, EventArgs e)
        {
            dgv_providers.AutoGenerateColumns = false;
            dgv_providers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            if (!(Program.user.isAdmin() || Program.user.isContract()))
            {
                btn_add.Enabled = false;
                isReadOnly = true;
            }

            updateProvidersTable();
        }

        private void dgv_providers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_providers.SelectedRows != null && !isReadOnly)
            {
                btn_delete.Enabled = true;
                btn_change.Enabled = true;
            }
            else
            {
                btn_delete.Enabled = false;
                btn_change.Enabled = false;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormProvidersAdd form = new FormProvidersAdd();
            form.ShowDialog();

            updateProvidersTable();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            int PK_Provider = Convert.ToInt32(dgv_providers.SelectedRows[0].Cells[7].Value);
            Provider deletingProvider = Program.db.Providers.Find(PK_Provider);

            if (deletingProvider != null)
            {
                FormProvidersAdd form = new FormProvidersAdd(deletingProvider);
                form.ShowDialog();

                updateProvidersTable();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int PK_Provider = Convert.ToInt32(dgv_providers.SelectedRows[0].Cells[7].Value);

                if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Provider deletingProvider = Program.db.Providers.Find(PK_Provider);

                    if (deletingProvider != null)
                    {
                        Program.db.Providers.Remove(deletingProvider);
                        Program.db.SaveChanges();
                    }
                }

                //обновляем тоблицу
                updateProvidersTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления, " + ex.ToString());
            }
        }

        private void updateProvidersTable()
        {
            findProviders();

            dgv_providers.DataSource = providers;

            dgv_providers.Columns[7].DataPropertyName = "PK_Provider";
            dgv_providers.Columns[6].DataPropertyName = "BIK";
            dgv_providers.Columns[5].DataPropertyName = "CorrespondentAccount";
            dgv_providers.Columns[4].DataPropertyName = "CheckingAccount";
            dgv_providers.Columns[3].DataPropertyName = "PhoneNumber";
            dgv_providers.Columns[2].DataPropertyName = "Address";
            dgv_providers.Columns[1].DataPropertyName = "INN";
            dgv_providers.Columns[0].DataPropertyName = "Name";
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            updateProvidersTable();
        }

        private void findProviders()
        {
            List<Provider> foundProviders = new List<Provider>();

            bool nameCriterium = tb_name.Text != string.Empty;
            string name = tb_name.Text.ToLower();

            bool addressCriterium = tb_address.Text != string.Empty;
            string address = tb_address.Text.ToLower();

            bool phoneNumberCriterium = tb_phoneNumber.Text != "+7 (   )    -  -";
            string phoneNumber = tb_phoneNumber.Text.ToLower();

            bool INNCriterium = tb_INN.Text != string.Empty;
            string INN = tb_INN.Text.ToLower();

            bool checkingAccountCriterium = tb_checkingAccount.Text != string.Empty;
            string checkingAccount = tb_checkingAccount.Text.ToLower();

            bool correspondentAccountCriterium = tb_correspondentAccount.Text != string.Empty;
            string correspondentAccount = tb_correspondentAccount.Text.ToLower();

            bool BIKCriterium = tb_BIK.Text != string.Empty;
            string BIK = tb_BIK.Text.ToLower();

            foreach (Provider provider in Program.db.Providers)
            {
                bool nameFound = !nameCriterium;
                bool addressFound = !addressCriterium;
                bool phoneNumberFound = !phoneNumberCriterium;
                bool INNFound = !INNCriterium;
                bool checkingAccountFound = !checkingAccountCriterium;
                bool correspondentAccountFound = !correspondentAccountCriterium;
                bool BIKFound = !BIKCriterium;

                if (nameCriterium && provider.Name.ToLower().Contains(name))
                    nameFound = true;

                if (addressCriterium && provider.Address.ToLower().Contains(address))
                    addressFound = true;

                if (phoneNumberCriterium && provider.PhoneNumber.ToLower().Contains(phoneNumber))
                    phoneNumberFound = true;

                if (INNCriterium && provider.INN.ToLower().Contains(INN))
                    INNFound = true;

                if (checkingAccountCriterium && provider.CheckingAccount.ToLower().Contains(checkingAccount))
                    checkingAccountFound = true;

                if (correspondentAccountCriterium && provider.CorrespondentAccount.ToLower().Contains(correspondentAccount))
                    correspondentAccountFound = true;

                if (BIKCriterium && provider.BIK.ToLower().Contains(BIK))
                    BIKFound = true;

                if (nameFound && addressFound && phoneNumberFound && INNFound 
                    && checkingAccountFound && correspondentAccountFound && BIKFound)
                    foundProviders.Add(provider);
            }

            providers = foundProviders;
        }
    }
}
