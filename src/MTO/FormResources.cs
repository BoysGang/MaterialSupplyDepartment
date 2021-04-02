using MTO.Models;
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
    public partial class FormResources : Form
    {
        public FormResources()
        {
            InitializeComponent();
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["ColumnResourceType"].Value = "Материал";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormResourcesAdd form = new FormResourcesAdd();
            form.ShowDialog();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            int PK_Resource = Convert.ToInt32(dgv_resources.SelectedRows[0].Cells[0].Value);
            Resource updatingResource = Program.db.Resources.Find(PK_Resource);

            if (updatingResource != null)
            {
                FormResourcesAdd form = new FormResourcesAdd(updatingResource);
                form.ShowDialog();
            }
        }

        private void FormResources_Load(object sender, EventArgs e)
        {
            dgv_resources.AutoGenerateColumns = false;
        }

        private void updateResourceTable()
        {
            List<Resource> resources = Program.db.Resources.ToList();
            dgv_resources.DataSource = resources;

            dgv_resources.Columns[0].DataPropertyName = "PK_Resource";
            dgv_resources.Columns[1].DataPropertyName = "Cipher";
            dgv_resources.Columns[2].DataPropertyName = "Name";
            dgv_resources.Columns[3].DataPropertyName = "Unit";
            dgv_resources.Columns[4].DataPropertyName = "ResourceType";
        }

        private void FormResources_Activated(object sender, EventArgs e)
        {
            updateResourceTable();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int PK_Resource = Convert.ToInt32(dgv_resources.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Resource deletingResource = Program.db.Resources.Find(PK_Resource);

                    if (deletingResource != null)
                    {
                        Program.db.Resources.Remove(deletingResource);
                        Program.db.SaveChanges();
                    }
                }

                //обновляем тоблицу
                updateResourceTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления, " + ex.ToString());
            }
        }

        private void dgv_resources_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_resources.SelectedRows != null)
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
    }
}
