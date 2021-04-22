using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using MTO.Models;
using MTO.Utils;

namespace MTO
{
    public partial class FormContractAdd : Form
    {
        private Contract currContract = null;

        private List<int> deletedLines = new List<int>();


        private const string formHeaderText = "Редактирование договора";
        private const string btnAddText = "Изменить";


        DateTimePicker dtp;
        public FormContractAdd(Contract contract = null)
        {
            InitializeComponent();

            dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Visible = false;
            dtp.Width = 85;
            dgv_contractlines.Controls.Add(dtp);

            dtp.ValueChanged += dtp_ValueChanged;

            List<Provider> providers = Program.db.Providers.ToList();
            cb_provider.DataSource = providers;

            List<Resource> resources = Program.db.Resources.ToList();
            var resourcesData = resources.Select(item => new { item.PK_Resource, item.Name }).ToList();
            ((DataGridViewComboBoxColumn)dgv_contractlines.Columns["Resource"]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dgv_contractlines.Columns["Resource"]).ValueMember = "PK_Resource";
            ((DataGridViewComboBoxColumn)dgv_contractlines.Columns["Resource"]).DataSource = resourcesData;

            if (contract != null)
            {
                this.currContract = contract;
                this.Text = formHeaderText;
                btn_AddNClose.Text = btnAddText;
                btn_cancelAdd.Location = btn_add.Location;
                btn_add.Visible = false;

                fillDataFromSource();
                fillLinesTable();
            }
        }

        private void fillDataFromSource()
        {
            tb_actNumber.Text = currContract.ContractNumber;
            tb_conclusionCity.Text = currContract.ConclusionCity;

            tb_customerAgentName.Text = currContract.CustomerAgentName;
            tb_customerAgentRole.Text = currContract.CustomerAgentRole;

            tb_providerAgentName.Text = currContract.ProviderAgentName;
            tb_providerAgentRole.Text = currContract.ProviderAgentRole;

            dtp_conclusionDate.Value = currContract.ConclusionDate;
            dtp_startDate.Value = currContract.StartDate;
            dtp_expiredDate.Value = currContract.ExpiredDate;

            nud_customerPenalty.Value = currContract.CustomerPenalty;
            nud_supplierPenalty.Value = currContract.SupplierPenalty;

            cb_provider.Text = currContract.Provider.Name;
        }

        private void fillLinesTable()
        {
            List<ContractLine> lines = currContract.getContractLines();

            for (int i = 0; i < lines.Count; i++)
            {
                dgv_contractlines.Rows.Add();
                dgv_contractlines.Rows[i].Cells[0].Value = lines[i].PK_ContractLine;
                dgv_contractlines.Rows[i].Cells[1].Value = lines[i].PK_Resource;
                dgv_contractlines.Rows[i].Cells[3].Value = lines[i].Amount;
                dgv_contractlines.Rows[i].Cells[4].Value = lines[i].Resource.Unit.Name;
                dgv_contractlines.Rows[i].Cells[6].Value = lines[i].UnitPrice;
                dgv_contractlines.Rows[i].Cells[8].Value = lines[i].DeliveryDate;
            }
        }
        private void btn_cancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool validateInput()
        {
            if(tb_actNumber.Text == String.Empty)
            {
                MessageBox.Show("Пустой номер договора!");
                return false;
            }
            else if (tb_conclusionCity.Text == String.Empty)
            {
                MessageBox.Show("Пустое место заключения!");
                return false;
            }
            else if (cb_provider.Text == String.Empty)
            {
                MessageBox.Show("Пустой поставщик!");
                return false;
            }
            else if (dtp_startDate.Value > dtp_expiredDate.Value)
            {
                MessageBox.Show("Ошибка в датах договора");
                return false;
            }
            else
            {
                for (int i = 0; i < dgv_contractlines.Rows.Count - 1; i++)
                    if (dgv_contractlines.Rows[i].Cells["Resource"].Value == null)
                    {
                        MessageBox.Show("Выберите ресурс!");
                        return false;
                    } else if(dgv_contractlines.Rows[i].Cells["DeliveryDate"].Value == null)
                    {
                        MessageBox.Show("Введите дату доставки!");
                        return false;
                    }

                return true;
            }
        }
        //сохранение контракта в БД
        private bool saveModel()
        {
            if (validateInput())
            {
                if (currContract != null)
                {
                    currContract.ContractNumber = tb_actNumber.Text;
                    currContract.ConclusionCity = tb_conclusionCity.Text;

                    currContract.CustomerAgentName = tb_customerAgentName.Text;
                    currContract.CustomerAgentRole = tb_customerAgentRole.Text;
                    currContract.ProviderAgentName = tb_providerAgentName.Text;
                    currContract.ProviderAgentRole = tb_providerAgentRole.Text;

                    currContract.PK_Provider = ((Provider)cb_provider.SelectedItem).PK_Provider;

                    currContract.ConclusionDate = dtp_conclusionDate.Value;
                    currContract.ExpiredDate = dtp_expiredDate.Value;
                    currContract.StartDate = dtp_startDate.Value;

                    currContract.SupplierPenalty = nud_supplierPenalty.Value;
                    currContract.CustomerPenalty = nud_customerPenalty.Value;


                    Program.db.Contracts.Update(currContract);


                    //refresh contract lines
                    List<ContractLine> lines = currContract.getContractLines();
                    for (int i = 0; i < dgv_contractlines.Rows.Count - 1; i++)
                    {
                        //добавляем в бд, если нет ключа
                        if (dgv_contractlines.Rows[i].Cells[0].Value == null)
                        {
                            float amount = 0;
                            if (dgv_contractlines.Rows[i].Cells["Amount"].Value != null)
                                float.TryParse(dgv_contractlines.Rows[i].Cells["Amount"].Value.ToString(),
                                    NumberStyles.Float, CultureInfo.InvariantCulture, out amount);

                            Decimal unitPrice = 0;
                            if (dgv_contractlines.Rows[i].Cells["UnitPrice"].Value != null)
                                Decimal.TryParse(dgv_contractlines.Rows[i].Cells["UnitPrice"].Value.ToString(),
                                    NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out unitPrice);

                            ContractLine line = new ContractLine()
                            {
                                PK_Contract = currContract.PK_Contract,
                                Amount = amount,
                                UnitPrice = unitPrice,
                                DeliveryDate = DateTime.Parse(dgv_contractlines.Rows[i].Cells["DeliveryDate"].Value == null ?
                                                            DateTime.Now.ToString() : dgv_contractlines.Rows[i].Cells["DeliveryDate"].Value.ToString()),
                                PK_Resource = (int)dgv_contractlines.Rows[i].Cells["Resource"].Value
                            };

                            Program.db.ContractLines.Add(line);
                            Program.db.SaveChanges();
                        }
                        else
                        {
                            //иначе обновляем существующий contractline
                            int pk_line = int.Parse(dgv_contractlines.Rows[i].Cells[0].Value.ToString());

                            int pk_resource = (int)dgv_contractlines.Rows[i].Cells[1].Value;
                            
                            float amount = 0;
                            if(dgv_contractlines.Rows[i].Cells["Amount"].Value != null)
                                float.TryParse(dgv_contractlines.Rows[i].Cells["Amount"].Value.ToString(),
                                    NumberStyles.Float, CultureInfo.InvariantCulture, out amount);

                            Decimal unitPrice = 0;
                            if (dgv_contractlines.Rows[i].Cells["UnitPrice"].Value != null)
                                Decimal.TryParse(dgv_contractlines.Rows[i].Cells["UnitPrice"].Value.ToString(),
                                    NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out unitPrice);
                           
                            DateTime deliveryDate = DateTime.Parse(dgv_contractlines.Rows[i].Cells["DeliveryDate"].Value.ToString() == String.Empty ?
                                                            DateTime.Now.ToString() : dgv_contractlines.Rows[i].Cells["DeliveryDate"].Value.ToString());

                            ContractLine singleLine = lines.Find((item) => item.PK_ContractLine == pk_line);


                            singleLine.PK_Resource = pk_resource;

                            singleLine.Amount = amount;
                            singleLine.UnitPrice = unitPrice;
                            singleLine.DeliveryDate = deliveryDate;

                            Program.db.ContractLines.Update(singleLine);
                            Program.db.SaveChanges();
                        }
                    }

                    // Delete deleted lines
                    foreach (int id in deletedLines)
                    {
                        ContractLine line = lines.Find((item) => item.PK_ContractLine == id);
                        Program.db.ContractLines.Remove(line);
                        Program.db.SaveChanges();
                    }
                }
                else
                {
                    Contract newContract = new Contract()
                    {
                        IsOpened = true,
                        ContractNumber = tb_actNumber.Text,
                        ConclusionCity = tb_conclusionCity.Text,

                        ConclusionDate = dtp_conclusionDate.Value,
                        StartDate = dtp_startDate.Value,
                        ExpiredDate = dtp_expiredDate.Value,

                        ProviderAgentName = tb_providerAgentName.Text,
                        ProviderAgentRole = tb_providerAgentRole.Text,
                        CustomerAgentName = tb_customerAgentName.Text,
                        CustomerAgentRole = tb_customerAgentRole.Text,

                        SupplierPenalty = nud_supplierPenalty.Value,
                        CustomerPenalty = nud_customerPenalty.Value,

                        PK_Provider = ((Provider)cb_provider.SelectedItem).PK_Provider,
                        PK_OrganizationDescription = Program.db.OrganizationDescriptions.FirstOrDefault().PK_OrganizationDescription
                    };

                    Program.db.Contracts.Add(newContract);
                    Program.db.SaveChanges();

                    //add contractLines
                    for(int i = 0; i < dgv_contractlines.Rows.Count - 1; i++)
                    {
                        float amount = 0;
                        if (dgv_contractlines.Rows[i].Cells["Amount"].Value != null)
                            float.TryParse(dgv_contractlines.Rows[i].Cells["Amount"].Value.ToString(),
                                NumberStyles.Float, CultureInfo.InvariantCulture, out amount);
                        
                        Decimal unitPrice = 0;
                        if (dgv_contractlines.Rows[i].Cells["UnitPrice"].Value != null)
                            Decimal.TryParse(dgv_contractlines.Rows[i].Cells["UnitPrice"].Value.ToString(),
                                NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out unitPrice);


                        ContractLine currLine = new ContractLine()
                        {
                            PK_Resource = (int)dgv_contractlines.Rows[i].Cells["Resource"].Value,
                            Amount = amount,
                            UnitPrice = unitPrice,
                            DeliveryDate = DateTime.Parse(dgv_contractlines.Rows[i].Cells["DeliveryDate"].Value == null ?
                                                            DateTime.Now.ToString() : dgv_contractlines.Rows[i].Cells["DeliveryDate"].Value.ToString()),
                            PK_Contract = newContract.PK_Contract
                        };

                        Program.db.ContractLines.Add(currLine);
                    }
                }

                Program.db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        //очистка данных в полях ввода
        private void clearData()
        {
            tb_actNumber.Clear();
            tb_conclusionCity.Clear();

            tb_customerAgentName.Clear();
            tb_customerAgentRole.Clear();
            tb_providerAgentName.Clear();
            tb_providerAgentRole.Clear();

            dtp_conclusionDate.Value = DateTime.Now;
            dtp_startDate.Value = DateTime.Now;
            dtp_expiredDate.Value = DateTime.Now;

            cb_provider.SelectedIndex = -1;

            nud_customerPenalty.Value = 0;
            nud_supplierPenalty.Value = 0;

            dgv_contractlines.Rows.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (saveModel())
            {
                if(currContract == null)
                    MessageBox.Show("Успешно добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Успешно изменена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                clearData();
            }
        }

        private void btn_AddNClose_Click(object sender, EventArgs e)
        {
            if (saveModel())
            {
                if (currContract == null)
                    MessageBox.Show("Успешно добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Успешно изменена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void dgv_contractlines_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_contractlines.CurrentCell != null && dgv_contractlines.CurrentCell.ColumnIndex == 8)
            {
                dgv_contractlines.CurrentCell.Value = dtp.Value.Date;
            }
            else
                updateCiphers(e.RowIndex, e.ColumnIndex);
        }
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            dgv_contractlines.CurrentCell.Value = dtp.Text;
        }

        private void updateCiphers(int activeRow, int activeColumn)
        {
            int currRow = activeRow;
            int currCol = activeColumn;

            if (currRow < 0)
                return;

            if (currCol == 1)
            {
                try
                {
                    int PK_Resource;
                    if (dgv_contractlines.Rows[currRow].Cells[1].Value != null)
                    {
                        if (!Int32.TryParse(dgv_contractlines.Rows[currRow].Cells[1].Value.ToString(), out PK_Resource))
                        {
                            MessageBox.Show("Неверный PK для ресурса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Resource res = Program.db.Resources.Find(PK_Resource);
                        dgv_contractlines.Rows[currRow].Cells[2].Value = res.Cipher;
                        dgv_contractlines.Rows[currRow].Cells[4].Value = res.Unit.Name;
                        dgv_contractlines.Rows[currRow].Cells[5].Value = res.Unit.Cipher;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_contractlines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateCiphers(e.RowIndex, e.ColumnIndex);

            //обновление общей стоимости
            if(e.RowIndex > -1 && (e.ColumnIndex == 3 || e.ColumnIndex == 6))
            {
                try
                {
                    float unitPrice = 0, amount = 0;
                    if (dgv_contractlines.Rows[e.RowIndex].Cells["UnitPrice"].Value != null)
                        float.TryParse(dgv_contractlines.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString(),
                            NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out unitPrice);

                    if (dgv_contractlines.Rows[e.RowIndex].Cells["Amount"].Value != null)
                        float.TryParse(dgv_contractlines.Rows[e.RowIndex].Cells["Amount"].Value.ToString(),
                            NumberStyles.Float, CultureInfo.InvariantCulture, out amount);

                    dgv_contractlines.Rows[e.RowIndex].Cells["TotalPrice"].Value = (unitPrice * amount).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_contractlines_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_contractlines.IsCurrentCellDirty)
            {
                dgv_contractlines.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgv_contractlines_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var comboBox = e.Control as DataGridViewComboBoxEditingControl;
            if (comboBox != null)
            {
                comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }


            // Amount fields KeyPress
            e.Control.KeyPress -= new KeyPressEventHandler(floatFieldsKeyPress);
            if (dgv_contractlines.CurrentCell.ColumnIndex == 3 || dgv_contractlines.CurrentCell.ColumnIndex == 6)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(floatFieldsKeyPress);
                }
            }

            e.CellStyle.BackColor = dgv_contractlines.DefaultCellStyle.BackColor;

        }

        private void floatFieldsKeyPress(object sender, KeyPressEventArgs e)
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

        private void dgv_contractlines_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgv_contractlines.CurrentCell.ColumnIndex == 8)
            {
                dtp.Location = dgv_contractlines.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                dtp.Visible = true;
                
                if (dgv_contractlines.CurrentCell.Value != null)
                {
                    dtp.Value = (DateTime)dgv_contractlines.CurrentCell.Value;
                }
                else
                {
                    dtp.Value = DateTime.Today;
                }
            }
            else
                dtp.Visible = false;
        }

        private void btn_deleteLine_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_contractlines.SelectedRows.Count == 0 
                    || dgv_contractlines.Rows.Count - 1 == dgv_contractlines.CurrentCell.RowIndex)
                {
                    MessageBox.Show("Выберите строку для удаления!");
                    return;
                }

                int selectedItem = dgv_contractlines.CurrentCell.RowIndex;

                if (currContract != null && dgv_contractlines.Rows[selectedItem].Cells[0].Value != null)
                    deletedLines.Add(Int32.Parse(dgv_contractlines.Rows[selectedItem].Cells[0].Value.ToString()));

                dgv_contractlines.Rows.RemoveAt(selectedItem);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         }

        private void tb_actNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ModifierKeys.HasFlag(Keys.Control))
                e.Handled = !TextValidator.isNumber(e.KeyChar.ToString());
        }

        private void FormContractAdd_Load(object sender, EventArgs e)
        {
            dgv_contractlines.AutoGenerateColumns = false;
            dgv_contractlines.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_contractlines.Columns["Resource"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dgv_contractlines_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dtp.Visible = false;
        }
    }
}
