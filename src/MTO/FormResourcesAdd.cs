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
    public partial class FormResourcesAdd : Form
    {
        private Resource resource = null;
        public FormResourcesAdd(Resource resource = null)
        {
            InitializeComponent();

            List<Unit> units = Program.db.Units.ToList();
            cb_unit.DataSource = units;

            List<ResourceType> types = Program.db.ResourceTypes.ToList();
            cb_type.DataSource = types;

            if (resource != null)
            {
                this.Text = "Редактирование ресурса";
                btn_add.Text = "Изменить";

                tb_name.Text = resource.Name;
                tb_cipher.Text = resource.Cipher;

                cb_unit.Text = resource.Unit.Name;
                cb_type.Text = resource.ResourceType.Name;

                this.resource = resource;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (resource != null)
            {
                resource.Name = tb_name.Text;
                resource.Cipher = tb_cipher.Text;
                resource.PK_Unit = ((Unit) cb_unit.SelectedItem).PK_Unit;
                resource.PK_ResourceType = ((ResourceType) cb_type.SelectedItem).PK_ResourceType;

                Program.db.Resources.Update(resource);
            }
            else
            {
                Resource newResource = new Resource()
                {
                    Name = tb_name.Text,
                    Cipher = tb_cipher.Text,
                    PK_Unit = ((Unit)cb_unit.SelectedItem).PK_Unit,
                    PK_ResourceType = ((ResourceType)cb_type.SelectedItem).PK_ResourceType,
                };
                
                Program.db.Resources.Add(newResource);
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
