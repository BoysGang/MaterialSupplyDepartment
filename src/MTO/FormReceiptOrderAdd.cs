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
    public partial class FormReceiptOrderAdd : Form
    {
        private ReceiptOrder order = null;

        public FormReceiptOrderAdd(ReceiptOrder order = null)
        {
            InitializeComponent();

            List<Provider> providers = Program.db.Providers.ToList();
            cb_provider.DataSource = providers;

            List<Contract> contracts = Program.db.Contracts.ToList();
            cb_contractNumber.DataSource = contracts;

            List<Warehouse> warehouses = Program.db.Warehouses.ToList();
            cb_warehouseCipher.DataSource = warehouses;

            List<Resource> resources = Program.db.Resources.ToList();
            var resourcesData = resources.Select(item => new { item.PK_Resource, item.Name }).ToList();
            ((DataGridViewComboBoxColumn)dgv_orderLines.Columns["Resource"]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dgv_orderLines.Columns["Resource"]).ValueMember = "PK_Resource";
            ((DataGridViewComboBoxColumn)dgv_orderLines.Columns["Resource"]).DataSource = resourcesData;

            List<Unit> units = Program.db.Units.ToList();
            var unitNames = units.Select(item => new { item.PK_Unit, item.Name }).ToList();
            ((DataGridViewComboBoxColumn)dgv_orderLines.Columns["Unit"]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dgv_orderLines.Columns["Unit"]).ValueMember = "PK_Unit";
            ((DataGridViewComboBoxColumn)dgv_orderLines.Columns["Unit"]).DataSource = unitNames;

            if (order != null)
            {
                this.Text = "Редактирование приходного ордера";
                btn_addNClose.Text = "Изменить";
                
                Point point = btn_add.Location;
                btn_cancelAdd.Location = point;
                
                btn_add.Visible = false;

                tb_receiptOrderNumber.Text = order.ReceiptOrderNumber;
                cb_contractNumber.Text = order.Contract.ContractNumber;
                cb_provider.Text = order.Provider.Name;
                cb_warehouseCipher.Text = order.Warehouse.Cipher;

                this.order = order;
            }
        }

        private void btn_cancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReceiptOrderAdd_Load(object sender, EventArgs e)
        {
            dgv_orderLines.AutoGenerateColumns = false;
            dgv_orderLines.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_orderLines_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            updateCiphers(e.RowIndex, e.ColumnIndex);
        }

        private void dgv_orderLines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateCiphers(e.RowIndex, e.ColumnIndex);
        }

        private void dgv_orderLines_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_orderLines.IsCurrentCellDirty)
            {
                dgv_orderLines.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void updateCiphers(int activeRow, int activeColumn)
        {
            int currentColumn = activeColumn;
            int currentRow = activeRow;

            if (activeRow < 0) return;

            if (currentColumn == 0)
            {
                try
                {   
                    var PK_Resource = dgv_orderLines.Rows[currentRow].Cells[0].Value;
                    string resourceCipher = Program.db.Resources.Find(PK_Resource).Cipher;
                    
                    dgv_orderLines.Rows[currentRow].Cells[1].Value = resourceCipher;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            if (currentColumn == 2)
            {
                try
                {
                    var PK_Unit = dgv_orderLines.Rows[currentRow].Cells[2].Value;
                    string unitCipher = Program.db.Units.Find(PK_Unit).Cipher;

                    dgv_orderLines.Rows[currentRow].Cells[3].Value = unitCipher;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                saveReceiptOrder();
                clearAllFields();
            }
        }

        private void saveReceiptOrder()
        {
            if (order != null)
            {
                order.ReceiptOrderNumber = tb_receiptOrderNumber.Text;
                order.DeliveryDate = dtp_delivaryDate.Value;
                order.PK_Warehouse = ((Warehouse)cb_warehouseCipher.SelectedItem).PK_Warehouse;
                order.PK_Provider = ((Provider)cb_provider.SelectedItem).PK_Provider;
                order.PK_Contract = ((Contract)cb_contractNumber.SelectedItem).PK_Contract;

                Program.db.ReceiptOrders.Update(order);
                MessageBox.Show("Запись изменена.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReceiptOrder receiptOrder = new ReceiptOrder()
                {
                    ReceiptOrderNumber = tb_receiptOrderNumber.Text,
                    DeliveryDate = dtp_delivaryDate.Value,
                    PK_Warehouse = ((Warehouse)cb_warehouseCipher.SelectedItem).PK_Warehouse,
                    PK_Provider = ((Provider)cb_provider.SelectedItem).PK_Provider,
                    PK_Contract = ((Contract)cb_contractNumber.SelectedItem).PK_Contract,
                };

                Program.db.ReceiptOrders.Add(receiptOrder);
                MessageBox.Show("Запись добавлена.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            Program.db.SaveChanges();
        }

        private void clearAllFields()
        {
            tb_receiptOrderNumber.Clear();
            dtp_delivaryDate.Value = DateTime.Now;
            cb_warehouseCipher.SelectedIndex = -1;
            cb_provider.SelectedIndex = -1;
            cb_contractNumber.SelectedIndex = -1;
        }

        private bool validateFields()
        {
            if (tb_receiptOrderNumber.Text == String.Empty)
            {
                MessageBox.Show("Введите номер", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cb_warehouseCipher.Text == String.Empty)
            {
                MessageBox.Show("Выберите шифр склада", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cb_provider.Text == String.Empty)
            {
                MessageBox.Show("Выберите поставщика", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cb_contractNumber.Text == String.Empty)
            {
                MessageBox.Show("Выберите номер договора", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btn_addNClose_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                saveReceiptOrder();
                this.Close();
            }
        }
    }
}
