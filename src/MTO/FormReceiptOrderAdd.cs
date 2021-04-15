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
    public partial class FormReceiptOrderAdd : Form
    {
        private ReceiptOrder order = null;
        private List<int> deletedLines = new List<int>();

        public FormReceiptOrderAdd(ReceiptOrder order = null)
        {
            InitializeComponent();

            dgv_orderLines.AutoGenerateColumns = false;
            dgv_orderLines.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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

            if (order != null)
            {
                this.order = order;

                this.Text = "Редактирование приходного ордера";
                btn_addNClose.Text = "Изменить";
                
                Point point = btn_add.Location;
                btn_cancelAdd.Location = point;
                
                btn_add.Visible = false;

                tb_receiptOrderNumber.Text = order.ReceiptOrderNumber;
                cb_contractNumber.Text = order.Contract.ContractNumber;
                cb_provider.Text = order.Provider.Name;
                cb_warehouseCipher.Text = order.Warehouse.Cipher;

                fillLinesTable();
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

            if (currentColumn == 1)
            {
                try
                {   
                    var PK_Resource = dgv_orderLines.Rows[currentRow].Cells[1].Value;
                    Resource resource = Program.db.Resources.Find(PK_Resource);

                    if (PK_Resource != null)
                    {
                        dgv_orderLines.Rows[currentRow].Cells[2].Value = resource.Cipher;
                        dgv_orderLines.Rows[currentRow].Cells[3].Value = resource.Unit.Name;
                        dgv_orderLines.Rows[currentRow].Cells[4].Value = resource.Unit.Cipher;
                    }
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
            string successMessage = String.Empty;
            
            if (order != null)
            {
                fillOrder(order);

                List<ReceiptOrderLine> lines = order.getReceiptOrderLines();

                // Save lines
                for (int i = 0; i < dgv_orderLines.Rows.Count - 1; i++)
                {
                    if(dgv_orderLines.Rows[i].Cells[0].Value == null)
                    {
                        addLineToDb(i, order);
                    }
                    else
                    {
                        int pk_line = int.Parse(dgv_orderLines.Rows[i].Cells[0].Value.ToString());
                        float acceptedAmount = float.Parse(dgv_orderLines.Rows[i].Cells[5].Value.ToString());
                        float documentedAmount = float.Parse(dgv_orderLines.Rows[i].Cells[6].Value.ToString());
                        int pk_resource = (int)dgv_orderLines.Rows[i].Cells[1].Value;

                        ReceiptOrderLine line = lines.Find((item) => item.PK_ReceiptOrderLine == pk_line);

                        line.AcceptedAmount = acceptedAmount;
                        line.DocumentAmount = documentedAmount;
                        line.PK_Resource = pk_resource;

                        Program.db.ReceiptOrderLines.Update(line);
                        Program.db.SaveChanges();
                    }
                }

                // Delete deleted lines
                foreach (int id in deletedLines)
                {
                    ReceiptOrderLine line = lines.Find((item) => item.PK_ReceiptOrderLine == id);
                    Program.db.ReceiptOrderLines.Remove(line);
                    Program.db.SaveChanges();
                }

                Program.db.ReceiptOrders.Update(order);
                successMessage = "изменена.";
            }
            else
            {
                // Save new ReceiptOrder
                ReceiptOrder receiptOrder = new ReceiptOrder();
                fillOrder(receiptOrder);

                Program.db.ReceiptOrders.Add(receiptOrder);
                Program.db.SaveChanges();

                // Save lines
                for (int i = 0; i < dgv_orderLines.Rows.Count - 1; i++)
                {
                    addLineToDb(i, receiptOrder);
                }

                successMessage = "добавлена.";
            }

            Program.db.SaveChanges();
            MessageBox.Show("Запись " + successMessage, "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearAllFields()
        {
            tb_receiptOrderNumber.Clear();
            dtp_delivaryDate.Value = DateTime.Now;
            
            cb_warehouseCipher.SelectedIndex = -1;
            cb_provider.SelectedIndex = -1;
            cb_contractNumber.SelectedIndex = -1;

            dgv_orderLines.Rows.Clear();
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

            for (int i = 0; i < dgv_orderLines.Rows.Count - 1; i++)
            {
                if (dgv_orderLines.Rows[i].Cells[1].Value == null)
                {
                    MessageBox.Show("Выберите ресурс", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (dgv_orderLines.Rows[i].Cells[5].Value == null)
                {
                    dgv_orderLines.Rows[i].Cells[5].Value = "0";
                }

                if (dgv_orderLines.Rows[i].Cells[6].Value == null)
                {
                    dgv_orderLines.Rows[i].Cells[6].Value = "0";
                }
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

        private void dgv_orderLines_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {   
            // Suggest in comboboxcell
            var comboBox = e.Control as DataGridViewComboBoxEditingControl;
            if (comboBox != null)
            {
                comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }

            // Amount fields KeyPress
            e.Control.KeyPress -= new KeyPressEventHandler(amountFieldsKeyPress);
            if (dgv_orderLines.CurrentCell.ColumnIndex == 5 || dgv_orderLines.CurrentCell.ColumnIndex == 6)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(amountFieldsKeyPress);
                }
            }
        }

        private void amountFieldsKeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void fillLinesTable()
        {
            List<ReceiptOrderLine> lines = order.getReceiptOrderLines();

            for (int i = 0; i < lines.Count; i++)
            {
                dgv_orderLines.Rows.Add();
                dgv_orderLines.Rows[i].Cells[0].Value = lines[i].PK_ReceiptOrderLine;
                dgv_orderLines.Rows[i].Cells[1].Value = lines[i].PK_Resource;
                dgv_orderLines.Rows[i].Cells[3].Value = lines[i].Resource.PK_Unit;
                dgv_orderLines.Rows[i].Cells[5].Value = lines[i].AcceptedAmount;
                dgv_orderLines.Rows[i].Cells[6].Value = lines[i].DocumentAmount;
            }
        }

        private void addLineToDb(int row, ReceiptOrder order)
        {
            ReceiptOrderLine line = new ReceiptOrderLine()
            {
                PK_ReceiptOrder = order.PK_ReceiptOrder,
                AcceptedAmount = float.Parse(dgv_orderLines.Rows[row].Cells[5].Value.ToString()),
                DocumentAmount = float.Parse(dgv_orderLines.Rows[row].Cells[6].Value.ToString()),
                PK_Resource = (int)dgv_orderLines.Rows[row].Cells[1].Value,
            };

            Program.db.ReceiptOrderLines.Add(line);
            Program.db.SaveChanges();
        }

        private void fillOrder(ReceiptOrder order)
        {
            order.ReceiptOrderNumber = tb_receiptOrderNumber.Text;
            order.DeliveryDate = dtp_delivaryDate.Value;
            order.PK_Warehouse = ((Warehouse)cb_warehouseCipher.SelectedItem).PK_Warehouse;
            order.PK_Provider = ((Provider)cb_provider.SelectedItem).PK_Provider;
            order.PK_Contract = ((Contract)cb_contractNumber.SelectedItem).PK_Contract;
        }

        private void btn_deleteLine_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgv_orderLines.CurrentCell.RowIndex;

            if (order != null && dgv_orderLines.Rows[selectedIndex].Cells[0].Value != null)
            {
                int pk_line = Int32.Parse(dgv_orderLines.Rows[selectedIndex].Cells[0].Value.ToString());
                deletedLines.Add(pk_line);
            }

            dgv_orderLines.Rows.RemoveAt(selectedIndex);
        }
    }
}
