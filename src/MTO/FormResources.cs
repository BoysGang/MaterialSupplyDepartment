using MTO.Models;
using MTO.Utils;
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
        private bool isReadOnly = false;

        List<Resource> resources;

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

            updateResourceTable();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            int PK_Resource = Convert.ToInt32(dgv_resources.SelectedRows[0].Cells[0].Value);
            Resource updatingResource = Program.db.Resources.Find(PK_Resource);

            if (updatingResource != null)
            {
                FormResourcesAdd form = new FormResourcesAdd(updatingResource);
                form.ShowDialog();

                updateResourceTable();
            }
        }

        private void FormResources_Load(object sender, EventArgs e)
        {
            dgv_resources.AutoGenerateColumns = false;
            dgv_resources.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            List<Unit> units = Program.db.Units.ToList();
            cb_unit.DataSource = units;
            cb_unit.SelectedIndex = -1;

            List<ResourceType> resourceTypes = Program.db.ResourceTypes.ToList();
            cb_type.DataSource = resourceTypes;
            cb_type.SelectedIndex = -1;

            if (!Program.user.isAdmin() && !Program.user.isContract())
            {
                btn_add.Enabled = false;
                isReadOnly = true;
            }

            updateResourceTable();
        }

        private void updateResourceTable()
        {
            findResources();

            dgv_resources.DataSource = resources;

            dgv_resources.Columns[0].DataPropertyName = "PK_Resource";
            dgv_resources.Columns[1].DataPropertyName = "Cipher";
            dgv_resources.Columns[2].DataPropertyName = "Name";
            dgv_resources.Columns[3].DataPropertyName = "Unit";
            dgv_resources.Columns[4].DataPropertyName = "ResourceType";
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
            if (dgv_resources.SelectedRows != null && !isReadOnly)
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

        private void tb_cipher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ModifierKeys.HasFlag(Keys.Control))
                e.Handled = !TextValidator.isCipher(e.KeyChar.ToString());
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            updateResourceTable();
        }

        private void findResources()
        {
            List<Resource> foundResources = new List<Resource>();

            bool cipherCriterium = tb_cipher.Text != string.Empty;
            string cipher = tb_cipher.Text.ToLower();

            bool nameCriterium = tb_name.Text != string.Empty;
            string name = tb_name.Text.ToLower();

            Unit unit = (Unit)cb_unit.SelectedItem;
            bool unitCriterium = false;
            int PK_Unit= -1;
            if (unit != null)
            {
                unitCriterium = true;
                PK_Unit = unit.PK_Unit;
            }

            ResourceType resourceType = (ResourceType)cb_type.SelectedItem;
            bool typeCriterium = false;
            int PK_ResourceType = -1;
            if (resourceType != null)
            {
                typeCriterium = true;
                PK_ResourceType = resourceType.PK_ResourceType;
            }

            foreach (Resource resource in Program.db.Resources)
            {
                bool cipherFound = !cipherCriterium;
                bool nameFound = !nameCriterium;
                bool unitFound = !unitCriterium;
                bool typeFound = !typeCriterium;

                if (cipherCriterium && resource.Cipher.ToLower().Contains(cipher))
                    cipherFound = true;

                if (nameCriterium && resource.Name.ToLower().Contains(name))
                    nameFound = true;

                if (unitCriterium && resource.PK_Unit == PK_Unit)
                    unitFound = true;

                if (typeCriterium && resource.PK_ResourceType == PK_ResourceType)
                    typeFound = true;

                if (cipherFound && nameFound && unitFound && typeFound)
                    foundResources.Add(resource);
            }

            resources = foundResources;
        }
    }
}
