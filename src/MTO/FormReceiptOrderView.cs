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
using System.Threading;

using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace MTO
{
    public partial class FormReceiptOrderView : Form
    {

        private string templatePath = "..//..//..//static//m-4.xlsx";
        private const int amountStringDefault = 8;//количество строк  в шаблоне изначально

        ReceiptOrder receiptOrder = null;

        public FormReceiptOrderView(ReceiptOrder receiptOrder)
        {
            InitializeComponent();

            this.receiptOrder = receiptOrder;

        }

        private void tsmi_editChange_Click(object sender, EventArgs e)
        {
            FormReceiptOrderAdd form = new FormReceiptOrderAdd(receiptOrder);
            form.ShowDialog();
        }

        private void FormReceiptOrderView_Activated(object sender, EventArgs e)
        {
            updateReceiptOrderTable();
            updateReceiptOrderLinesTable();
        }

        private void updateReceiptOrderTable()
        {
            dgv_receiptOrders.DataSource = new List<ReceiptOrder> { receiptOrder };

            dgv_receiptOrders.Columns[0].DataPropertyName = "PK_ReceiptOrder";
            dgv_receiptOrders.Columns[1].DataPropertyName = "DeliveryDateWithoutTime";
            dgv_receiptOrders.Columns[2].DataPropertyName = "Warehouse";
            dgv_receiptOrders.Columns[3].DataPropertyName = "Provider";
            dgv_receiptOrders.Columns[4].DataPropertyName = "Provider_INN";
            dgv_receiptOrders.Columns[5].DataPropertyName = "Contract";

            lbl_receiptOrderNumber.Text = "Приходной ордер № " + receiptOrder.ReceiptOrderNumber;
        }

        private void updateReceiptOrderLinesTable()
        {
            List<ReceiptOrderLine> lines = receiptOrder.getReceiptOrderLines();
            dgv_receiptOrderLines.DataSource = lines;

            dgv_receiptOrderLines.Columns[0].DataPropertyName = "PK_ReceiptOrderLine";
            dgv_receiptOrderLines.Columns[1].DataPropertyName = "Resource";
            dgv_receiptOrderLines.Columns[2].DataPropertyName = "Resource_Cipher";
            dgv_receiptOrderLines.Columns[3].DataPropertyName = "Resource_Unit";
            dgv_receiptOrderLines.Columns[4].DataPropertyName = "Resource_Unit_Cipher";
            dgv_receiptOrderLines.Columns[5].DataPropertyName = "AcceptedAmount";
            dgv_receiptOrderLines.Columns[6].DataPropertyName = "DocumentAmount";
            dgv_receiptOrderLines.Columns[7].DataPropertyName = "UnitPrice";
            dgv_receiptOrderLines.Columns[8].DataPropertyName = "TotalPrice";
        }

        private void FormReceiptOrderView_Load(object sender, EventArgs e)
        {
            dgv_receiptOrders.AutoGenerateColumns = false;
            dgv_receiptOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgv_receiptOrderLines.AutoGenerateColumns = false;
            dgv_receiptOrderLines.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_receiptOrders_SelectionChanged(object sender, EventArgs e)
        {
            dgv_receiptOrders.ClearSelection();
        }

        private void dgv_receiptOrderLines_SelectionChanged(object sender, EventArgs e)
        {
            dgv_receiptOrderLines.ClearSelection();
        }

        private void tsmi_editDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить данный приходной ордер?",
                "Подтвердите действие",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Удаляем запись
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (receiptOrder != null)
                    {
                        Program.db.ReceiptOrders.Remove(receiptOrder);
                        Program.db.SaveChanges();
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления, " + ex.ToString());
                }
            }
        }

        async void export()
        {
            try
            {
                //заполнение шапки
                sheet.Cells[5, "AN"] = receiptOrder.ReceiptOrderNumber.ToString();

                //organistaion description
                sheet.Cells[8, "M"] = receiptOrder.Contract.OrganizationDescription.Name;

                sheet.Cells[13, "M"] = receiptOrder.DeliveryDate;
                sheet.Cells[13, "U"] = receiptOrder.Warehouse.Cipher;
                sheet.Cells[13, "AC"] = receiptOrder.Provider.Name;
                sheet.Cells[13, "AO"] = receiptOrder.Provider.INN;
                sheet.Cells[13, "AV"] = "№ " + receiptOrder.Contract.ContractNumber + " от " + receiptOrder.Contract.ConclusionDate.ToShortDateString();

                List<ReceiptOrderLine> lines = receiptOrder.getReceiptOrderLines();
                int extraStringsAmount = 0;
                if (lines.Count > amountStringDefault)
                    extraStringsAmount = lines.Count - amountStringDefault;

                int endStringInDoc = 26;
                while (extraStringsAmount > 0)
                {
                    Excel.Range excel_str = sheet.get_Range("A" + 19.ToString(), "CA" + 22.ToString());
                    excel_str.Copy(Type.Missing);

                    Excel.Range r = (Excel.Range)sheet.Rows[endStringInDoc];
                    r.Insert(Excel.XlInsertShiftDirection.xlShiftDown);

                    Excel.Range paste = sheet.get_Range("A" + endStringInDoc.ToString(), "CA" + (endStringInDoc + 3).ToString());
                    paste.PasteSpecial(Microsoft.Office.Interop.Excel.XlPasteType.xlPasteAll,
                        Microsoft.Office.Interop.Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone,
                        Type.Missing, Type.Missing);

                    extraStringsAmount -= 4;
                    endStringInDoc += 4;
                }

                int startTableIndex = 18;
                for (int i = 0; i < lines.Count; i++)
                {
                    sheet.Cells[startTableIndex + i, "A"] = lines[i].Resource.Name;
                    sheet.Cells[startTableIndex + i, "R"] = lines[i].Resource.Cipher;
                    sheet.Cells[startTableIndex + i, "AA"] = lines[i].Resource.Unit.Cipher;
                    sheet.Cells[startTableIndex + i, "AG"] = lines[i].Resource.Unit.Name;
                    sheet.Cells[startTableIndex + i, "AT"] = lines[i].DocumentAmount.ToString();
                    sheet.Cells[startTableIndex + i, "BB"] = lines[i].AcceptedAmount.ToString();
                    sheet.Cells[startTableIndex + i, "BJ"] = lines[i].UnitPrice.ToString();
                    sheet.Cells[startTableIndex + i, "BR"] = lines[i].TotalPrice.ToString();
                }

                sheet.get_Range("A18", sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing)).
                    Rows.RowHeight = 30;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Errors!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Excel.Application app;
        private Excel.Workbook book;
        private Excel.Worksheet sheet;

        async Task Export()
        {
            await Task.Run(() =>
                export()
            );
        }

        private async void tsmi_fileExport_Click(object sender, EventArgs e)
        {
            System.Timers.Timer tmr_export = new System.Timers.Timer();

            app = new Excel.Application();

            book = app.Workbooks.Open(Path.Combine(Environment.CurrentDirectory, templatePath));
            sheet = (Excel.Worksheet)book.Sheets[1];

            pb_export.Value = 0;
            tmr_export.Elapsed += tmr_export_Tick;
            tmr_export.Interval = 100;
            tmr_export.Start();
                        
            await Export();

            tmr_export.Stop();
            pb_export.Value = 100;

            string fileName_new = String.Empty;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName_new = saveFileDialog.FileName;
            }
            else
            {
                pb_export.Value = 0;
                return;
            }

            FileInfo fileInfo = new FileInfo(fileName_new);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
            
            book.SaveAs(fileName_new, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing,
                Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing);

            saveFileDialog.Dispose();

            book.Close();
            app.Quit();

            MessageBox.Show("Файл успешно был сохранен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pb_export.Value = 0;
        }

        private void tmr_export_Tick(object sender, EventArgs e)
        {
            if (pb_export.Value == pb_export.Maximum)
                pb_export.Value = 0;
            else
                pb_export.Value  += 1;
        }
    }
}
