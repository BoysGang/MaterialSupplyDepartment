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
using System.IO;

using Excel = Microsoft.Office.Interop.Excel;

namespace MTO
{
    public partial class FormContractView : Form
    {
        private const string templateSpecPath = "..//..//..//static//contract-spec.xlsx";
        private string saveSpecName = "contract-spec.xlsx";
        private int amountStringDefault = 8;

        private string pathSave = String.Empty;

        private Contract contract;
        private string dateFormat = "dd.MM.yyyy";
        private string header = "Договор поставки № ";
        private string templateContractPath = "..//..//..//static//contract.rtf";
        private string saveContractName = "contract.rtf";


        public FormContractView(Contract contract)
        {
            InitializeComponent();

            this.contract = contract;
        }
        
        private void FormContractView_Load(object sender, EventArgs e)
        {
            dgv_contractLines.AutoGenerateColumns = false;
            dgv_contractLines.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            lbl_header.Text = header + contract.ContractNumber;

            fillDocument();
            fillSpecification();
        }

        private void tsmi_editChange_Click(object sender, EventArgs e)
        {
            FormContractAdd form = new FormContractAdd(contract);
            form.ShowDialog();

            lbl_header.Text = header + contract.ContractNumber;
            fillDocument();
            fillSpecification();
        }

        private void fillSpecification()
        {
            List<ContractLine> contractLines = contract.getContractLines();
            dgv_contractLines.DataSource = contractLines;

            dgv_contractLines.Columns[0].DataPropertyName = "PK_ContractLine";
            dgv_contractLines.Columns[1].DataPropertyName = "Resource";
            dgv_contractLines.Columns[2].DataPropertyName = "Resource_Cipher";
            dgv_contractLines.Columns[3].DataPropertyName = "Amount";
            dgv_contractLines.Columns[4].DataPropertyName = "Resource_Unit";
            dgv_contractLines.Columns[5].DataPropertyName = "Resource_Unit_Cipher";
            dgv_contractLines.Columns[6].DataPropertyName = "UnitPrice";
            dgv_contractLines.Columns[7].DataPropertyName = "TotalPrice";
            dgv_contractLines.Columns[8].DataPropertyName = "DeliveryDate";
        }

        private void fillDocument()
        {
            Provider provider = contract.Provider;
            OrganizationDescription orgDesc = Program.db.OrganizationDescriptions.First();

            Dictionary<string, string> replace = new Dictionary<string, string>
            {
                {"[ConclusionCity]",  contract.ConclusionCity},
                {"[ConclusionDate]",  contract.ConclusionDate.ToString(dateFormat)},
                {"[ProviderName]",  provider.Name},
                {"[ProviderAgentRole]",  contract.ProviderAgentRole},
                {"[CustomerName]",  orgDesc.Name},
                {"[CustomerAgentRole]",  contract.CustomerAgentRole},
                {"[SupplierPenalty]",  contract.SupplierPenalty.ToString()},
                {"[CustomerPenalty]",  contract.CustomerPenalty.ToString()},
                {"[StartDate]",  contract.StartDate.ToString(dateFormat)},
                {"[ExpiredDate]",  contract.ExpiredDate.ToString(dateFormat)},
                {"[ProviderAddress]",  provider.Address},
                {"[ProviderINN]",  provider.INN},
                {"[ProviderPhoneNumber]",  provider.PhoneNumber},
                {"[ProviderCheckingAccount]",  provider.CheckingAccount},
                {"[ProviderCorrespondentAccount]",  provider.CorrespondentAccount},
                {"[ProviderBIK]",  provider.BIK},
                {"[ProviderAgentName]",  contract.ProviderAgentName},
                {"[CustomerAddress]",  orgDesc.Address},
                {"[CustomerINN]",  orgDesc.INN},
                {"[CustomerPhoneNumber]",  orgDesc.PhoneNumber},
                {"[CustomerCheckingAccount]",  orgDesc.CheckingAccount},
                {"[CustomerCorrespondentAccount]",  orgDesc.CorrespondentAccount},
                {"[CustomerBIK]",  orgDesc.BIK},
                {"[CustomerAgentName]",  contract.CustomerAgentName},
            };

            rtb_document.LoadFile(templateContractPath);

            foreach (KeyValuePair<string, string> keyValue in replace)
            {
                int found = 1;

                while (true)
                {
                    found = rtb_document.Find(keyValue.Key);

                    if (found == -1)
                        break;

                    if (keyValue.Value == null || keyValue.Value == String.Empty)
                    {
                        rtb_document.SelectedText = rtb_document.SelectedText.Replace(keyValue.Key, " ");
                    }
                    else
                    {
                        rtb_document.SelectedText = rtb_document.SelectedText.Replace(keyValue.Key, keyValue.Value);
                    }
                }
            }
        }

        private void tsmi_editDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить данный договор?", "Подтвердите действие", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //удаляем запись
            if(result == DialogResult.Yes)
            {
                try
                {
                        if (contract != null)
                        {
                            Program.db.Contracts.Remove(contract);
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

        private void tsmi_fileExport_Click(object sender, EventArgs e)
        {
            pathSave = String.Empty;
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Выберите папку для экспорта файлов";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                pathSave = folderDialog.SelectedPath;
            }
            else
            {
                return;
            }

            saveContract();
            saveSpecification();

            string message = "Успешно сохранены файлы:\n" + saveSpecName + " и " + saveContractName;
            MessageBox.Show(message, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveContract()
        {
            rtb_document.SaveFile(Path.Combine(pathSave, saveContractName), RichTextBoxStreamType.RichNoOleObjs);
        }

        private Excel.Application app;
        private Excel.Workbook book;
        private Excel.Worksheet sheet;

        private void saveSpecification()
        {
            app = new Excel.Application();

            book = app.Workbooks.Open(Path.Combine(Environment.CurrentDirectory, templateSpecPath));
            sheet = (Excel.Worksheet)book.Sheets[1];

            //шапка 
            sheet.Cells[3, "BC"] = contract.ContractNumber.ToString();
            sheet.Cells[4, "AX"] = contract.ConclusionDate.ToString(dateFormat);

            //подвал
            sheet.Cells[23, "C"] = contract.Provider.Name;
            sheet.Cells[25, "C"] = contract.ProviderAgentRole;
            sheet.Cells[25, "I"] = contract.ProviderAgentName;

            sheet.Cells[23, "AO"] = contract.OrganizationDescription.Name;
            sheet.Cells[25, "AO"] = contract.CustomerAgentRole;
            sheet.Cells[25, "AU"] = contract.CustomerAgentName;

            //..тело
            List<ContractLine> lines = contract.getContractLines();
            int extraStringsAmount = 0;
            if (lines.Count > amountStringDefault)
                extraStringsAmount = lines.Count - amountStringDefault;

            int endStringInDoc = 19;
            while (extraStringsAmount > 0)
            {
                Excel.Range excel_str = sheet.get_Range("A" + 12.ToString(), "BQ" + 15.ToString());
                excel_str.Copy(Type.Missing);

                Excel.Range r = (Excel.Range)sheet.Rows[endStringInDoc];
                r.Insert(Excel.XlInsertShiftDirection.xlShiftDown);

                Excel.Range paste = sheet.get_Range("A" + endStringInDoc.ToString(), "BQ" + (endStringInDoc + 3).ToString());
                paste.PasteSpecial(Microsoft.Office.Interop.Excel.XlPasteType.xlPasteAll,
                    Microsoft.Office.Interop.Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone,
                    Type.Missing, Type.Missing);

                extraStringsAmount -= 4;
                endStringInDoc += 4;
            }

            int startTableIndex = 11;
            for (int i = 0; i < lines.Count; i++)
            {
                sheet.Cells[startTableIndex + i, "B"] = (i + 1).ToString();
                sheet.Cells[startTableIndex + i, "E"] = lines[i].Resource.Name;
                sheet.Cells[startTableIndex + i, "X"] = lines[i].Resource.Cipher;
                sheet.Cells[startTableIndex + i, "AE"] = lines[i].Amount;

                sheet.Cells[startTableIndex + i, "AJ"] = lines[i].Resource.Unit.Name;
                sheet.Cells[startTableIndex + i, "AS"] = lines[i].Resource.Unit.Cipher;

                sheet.Cells[startTableIndex + i, "AW"] = lines[i].UnitPrice.ToString();
                sheet.Cells[startTableIndex + i, "BB"] = lines[i].TotalPrice.ToString();
                sheet.Cells[startTableIndex + i, "BI"] = lines[i].DeliveryDate.ToString(dateFormat);
            }

            sheet.get_Range("A11", "BI" + (startTableIndex + lines.Count - 1).ToString()).
                Rows.RowHeight = 30;

            sheet.PageSetup.PrintArea = "";

            //сохранение
            FileInfo fileInfo = new FileInfo(Path.Combine(pathSave, saveSpecName));
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
            
            book.SaveAs(Path.Combine(pathSave, saveSpecName), Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing,
                Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing);

            book.Close();
            app.Quit();
        }
    }
}
