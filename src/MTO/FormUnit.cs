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
    public partial class FormUnit : Form
    {
        private bool isReadOnly = false;

        List<Unit> units;

        public FormUnit()
        {
            InitializeComponent();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            int PK_Unit = Convert.ToInt32(dgv_units.SelectedRows[0].Cells[2].Value);
            Unit changingUnit = Program.db.Units.Find(PK_Unit);

            if (changingUnit != null)
            {
                FormUnitAdd form = new FormUnitAdd(changingUnit);
                form.ShowDialog();

                updateUnitTable();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormUnitAdd form = new FormUnitAdd();
            form.ShowDialog();

            updateUnitTable();
        }

        private void FormUnit_Load(object sender, EventArgs e)
        {
            dgv_units.AutoGenerateColumns = false;
            dgv_units.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            if (!Program.user.isAdmin())
            {
                btn_add.Enabled = false;
                isReadOnly = true;
            }

            updateUnitTable();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int PK_Unit = Convert.ToInt32(dgv_units.SelectedRows[0].Cells[2].Value);

                if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Unit deletingUnit = Program.db.Units.Find(PK_Unit);

                    if (deletingUnit != null)
                    {
                        Program.db.Units.Remove(deletingUnit);
                        Program.db.SaveChanges();
                    }
                }

                //обновляем тоблицу
                updateUnitTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления, " + ex.ToString());
            }
        }

        private void updateUnitTable()
        {
            findUnits();

            dgv_units.DataSource = units;

            dgv_units.Columns[2].DataPropertyName = "PK_Unit";
            dgv_units.Columns[1].DataPropertyName = "Name";
            dgv_units.Columns[0].DataPropertyName = "Cipher";
        }

        private void dgv_units_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_units.SelectedRows != null && !isReadOnly)
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
            updateUnitTable();
        }

        private void findUnits()
        {
            List<Unit> foundUnits = new List<Unit>();

            bool cipherCriterium = tb_cipher.Text != string.Empty;
            bool nameCriterium = tb_name.Text != string.Empty;

            string cipher = tb_cipher.Text.ToLower();
            string name = tb_name.Text.ToLower();

            foreach (Unit unit in Program.db.Units)
            {
                bool cipherFound = !cipherCriterium;
                bool nameFound = !nameCriterium;

                if (cipherCriterium && unit.Cipher.ToLower().Contains(cipher))
                    cipherFound = true;

                if (nameCriterium && unit.Name.ToLower().Contains(name))
                    nameFound = true;

                if (cipherFound && nameFound)
                    foundUnits.Add(unit);
            }

            units = foundUnits;
        }
    }
}
