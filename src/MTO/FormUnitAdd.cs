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
    public partial class FormUnitAdd : Form
    {
        private Unit editingUnit = null;

        public FormUnitAdd(Unit editingUnit = null)
        {
            InitializeComponent();

            if (editingUnit != null)
            {
                this.Text = "Редактирование единицы измерения";

                tb_cipher.Text = editingUnit.Cipher;
                tb_name.Text = editingUnit.Name;

                btn_add.Text = "Изменить";

                this.editingUnit = editingUnit;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (editingUnit != null)
            {
                editingUnit.Name = tb_name.Text;
                editingUnit.Cipher = tb_cipher.Text;

                Program.db.Units.Update(editingUnit);
            }
            else
            {
                Unit newUnit = new Unit() { Name = tb_name.Text, Cipher = tb_cipher.Text };
                Program.db.Units.Add(newUnit);
            }

            Program.db.SaveChanges();
            this.Close();
        }

        private void tb_cipher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ModifierKeys.HasFlag(Keys.Control))
                e.Handled = !TextValidator.isCipher(e.KeyChar.ToString());
        }
    }
}
