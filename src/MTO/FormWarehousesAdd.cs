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
    public partial class FormWarehousesAdd : Form
    {
        private Warehouse editingWarehouse = null;

        public FormWarehousesAdd(Warehouse editingItem = null)
        {
            InitializeComponent();

            if (editingItem != null)
            {
                this.Text = "Редактирование Склада";

                tb_cipher.Text = editingItem.Cipher;
                tb_name.Text = editingItem.Name;

                btn_add.Text = "Изменить";

                this.editingWarehouse = editingItem;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (editingWarehouse != null)
            {
                editingWarehouse.Name = tb_name.Text;
                editingWarehouse.Cipher = tb_cipher.Text;

                Program.db.Warehouses.Update(editingWarehouse);
            }
            else
            {
                Warehouse newWarehouse = new Warehouse() { Name = tb_name.Text, Cipher = tb_cipher.Text };
                Program.db.Warehouses.Add(newWarehouse);
            }

            Program.db.SaveChanges();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_cipher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ModifierKeys.HasFlag(Keys.Control))
                e.Handled = !TextValidator.isCipher(e.KeyChar.ToString());
        }
    }
}
