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
        public FormProviders()
        {
            InitializeComponent();
        }

        private void FormProviders_Load(object sender, EventArgs e)
        {
            dgv_providers.AutoGenerateColumns = false;
            dgv_providers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void FormProviders_Activated(object sender, EventArgs e)
        {
            updateProvidersTable();
        }

        private void dgv_providers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_providers.SelectedRows != null)
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
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            int PK_Provider = Convert.ToInt32(dgv_providers.SelectedRows[0].Cells[7].Value);
            Provider deletingProvider = Program.db.Providers.Find(PK_Provider);

            if (deletingProvider != null)
            {
                FormProvidersAdd form = new FormProvidersAdd(deletingProvider);
                form.ShowDialog();
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
            List<Provider> providers = Program.db.Providers.ToList();
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
    }
}
