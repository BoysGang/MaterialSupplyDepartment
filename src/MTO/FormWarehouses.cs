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
    public partial class FormWarehouses : Form
    {
        private bool isReadOnly = false;

        List<Warehouse> warehouses;

        public FormWarehouses()
        {
            InitializeComponent();
        }

        private void FormWarehouses_Load(object sender, EventArgs e)
        {
            dgv_warehouses.AutoGenerateColumns = false;
            dgv_warehouses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            if (!Program.user.isAdmin() 
                && !Program.user.isContract())
            {
                btn_add.Enabled = false;
                isReadOnly = true;
            }

            updateWarehouseTable();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            int PK_Warehouse = Convert.ToInt32(dgv_warehouses.SelectedRows[0].Cells[2].Value);
            Warehouse changingWarehouse = Program.db.Warehouses.Find(PK_Warehouse);

            if (changingWarehouse != null)
            {
                FormWarehousesAdd form = new FormWarehousesAdd(changingWarehouse);
                form.ShowDialog();

                updateWarehouseTable();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormWarehousesAdd form = new FormWarehousesAdd();
            form.ShowDialog();

            updateWarehouseTable();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int PK_Warehouse = Convert.ToInt32(dgv_warehouses.SelectedRows[0].Cells[2].Value);

                if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Warehouse deletingItem = Program.db.Warehouses.Find(PK_Warehouse);

                    if (deletingItem != null)
                    {
                        Program.db.Warehouses.Remove(deletingItem);
                        Program.db.SaveChanges();
                    }
                }

                //обновляем тоблицу
                updateWarehouseTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления, " + ex.ToString());
            }
        }

        private void updateWarehouseTable()
        {
            findWarehouses();

            dgv_warehouses.DataSource = warehouses;

            dgv_warehouses.Columns[2].DataPropertyName = "PK_Warehouse";
            dgv_warehouses.Columns[1].DataPropertyName = "Name";
            dgv_warehouses.Columns[0].DataPropertyName = "Cipher";

        }

        private void dgv_warehouses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_warehouses.SelectedRows != null && !isReadOnly)
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
            updateWarehouseTable();
        }

        void findWarehouses()
        {
            List<Warehouse> foundWarehouses = new List<Warehouse>();

            bool cipherCriterium = tb_cipher.Text != string.Empty;
            bool nameCriterium = tb_name.Text != string.Empty;

            string cipher = tb_cipher.Text.ToLower();
            string name = tb_name.Text.ToLower();

            foreach (Warehouse warehouse in Program.db.Warehouses)
            {
                bool cipherFound = !cipherCriterium;
                bool nameFound = !nameCriterium;

                if (cipherCriterium && warehouse.Cipher.ToLower().Contains(cipher))
                    cipherFound = true;

                if (nameCriterium && warehouse.Name.ToLower().Contains(name))
                    nameFound = true;

                if (cipherFound && nameFound)
                    foundWarehouses.Add(warehouse);
            }

            warehouses = foundWarehouses;
        }
    }
}
