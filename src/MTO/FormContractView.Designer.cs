
namespace MTO
{
    partial class FormContractView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rtb_document = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_header = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_contractLines = new System.Windows.Forms.DataGridView();
            this.PK_ContractLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceCipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pb_export = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_fileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_editChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_editDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contractLines)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_document
            // 
            this.rtb_document.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_document.Location = new System.Drawing.Point(3, 3);
            this.rtb_document.Name = "rtb_document";
            this.rtb_document.ReadOnly = true;
            this.rtb_document.Size = new System.Drawing.Size(464, 333);
            this.rtb_document.TabIndex = 0;
            this.rtb_document.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_header, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pb_export, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 437);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_header.Location = new System.Drawing.Point(150, 11);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(184, 20);
            this.lbl_header.TabIndex = 2;
            this.lbl_header.Text = "Договор поставки №";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 365);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtb_document);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главное";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_contractLines);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спецификация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_contractLines
            // 
            this.dgv_contractLines.AllowUserToAddRows = false;
            this.dgv_contractLines.AllowUserToDeleteRows = false;
            this.dgv_contractLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_contractLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contractLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_ContractLine,
            this.ColumnName,
            this.ResourceCipher,
            this.ColumnAmount,
            this.ColumnUnit,
            this.UnitCipher,
            this.ColumnUnitPrice,
            this.ColumnPrice,
            this.ColumnDeliveryDate});
            this.dgv_contractLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_contractLines.Location = new System.Drawing.Point(3, 3);
            this.dgv_contractLines.Name = "dgv_contractLines";
            this.dgv_contractLines.ReadOnly = true;
            this.dgv_contractLines.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_contractLines.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_contractLines.Size = new System.Drawing.Size(464, 333);
            this.dgv_contractLines.TabIndex = 1;
            // 
            // PK_ContractLine
            // 
            this.PK_ContractLine.HeaderText = "PK_ContractLine";
            this.PK_ContractLine.Name = "PK_ContractLine";
            this.PK_ContractLine.ReadOnly = true;
            this.PK_ContractLine.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Наименование";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ResourceCipher
            // 
            this.ResourceCipher.HeaderText = "Шифр ресурса";
            this.ResourceCipher.Name = "ResourceCipher";
            this.ResourceCipher.ReadOnly = true;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.HeaderText = "Кол-во";
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.ReadOnly = true;
            // 
            // ColumnUnit
            // 
            this.ColumnUnit.HeaderText = "Ед. измерения";
            this.ColumnUnit.Name = "ColumnUnit";
            this.ColumnUnit.ReadOnly = true;
            this.ColumnUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UnitCipher
            // 
            this.UnitCipher.HeaderText = "Шифр ед. измерения";
            this.UnitCipher.Name = "UnitCipher";
            this.UnitCipher.ReadOnly = true;
            // 
            // ColumnUnitPrice
            // 
            this.ColumnUnitPrice.HeaderText = "Цена за единицу, руб.";
            this.ColumnUnitPrice.Name = "ColumnUnitPrice";
            this.ColumnUnitPrice.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Общая цена партии, руб.";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnDeliveryDate
            // 
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnDeliveryDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnDeliveryDate.HeaderText = "Срок поставки";
            this.ColumnDeliveryDate.Name = "ColumnDeliveryDate";
            this.ColumnDeliveryDate.ReadOnly = true;
            // 
            // pb_export
            // 
            this.pb_export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_export.Location = new System.Drawing.Point(3, 417);
            this.pb_export.Name = "pb_export";
            this.pb_export.Size = new System.Drawing.Size(478, 17);
            this.pb_export.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file,
            this.tsmi_edit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "ms_menuContracts";
            // 
            // tsmi_file
            // 
            this.tsmi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_fileExport});
            this.tsmi_file.Name = "tsmi_file";
            this.tsmi_file.Size = new System.Drawing.Size(48, 20);
            this.tsmi_file.Text = "Файл";
            // 
            // tsmi_fileExport
            // 
            this.tsmi_fileExport.Name = "tsmi_fileExport";
            this.tsmi_fileExport.Size = new System.Drawing.Size(180, 22);
            this.tsmi_fileExport.Text = "Экспорт";
            this.tsmi_fileExport.Click += new System.EventHandler(this.tsmi_fileExport_Click);
            // 
            // tsmi_edit
            // 
            this.tsmi_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_editChange,
            this.tsmi_editDelete});
            this.tsmi_edit.Name = "tsmi_edit";
            this.tsmi_edit.Size = new System.Drawing.Size(59, 20);
            this.tsmi_edit.Text = "Правка";
            // 
            // tsmi_editChange
            // 
            this.tsmi_editChange.Name = "tsmi_editChange";
            this.tsmi_editChange.Size = new System.Drawing.Size(180, 22);
            this.tsmi_editChange.Text = "Редактирование";
            this.tsmi_editChange.Click += new System.EventHandler(this.tsmi_editChange_Click);
            // 
            // tsmi_editDelete
            // 
            this.tsmi_editDelete.Name = "tsmi_editDelete";
            this.tsmi_editDelete.Size = new System.Drawing.Size(180, 22);
            this.tsmi_editDelete.Text = "Удаление";
            this.tsmi_editDelete.Click += new System.EventHandler(this.tsmi_editDelete_Click);
            // 
            // FormContractView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FormContractView";
            this.Text = "Просмотр договора";
            this.Load += new System.EventHandler(this.FormContractView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contractLines)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_document;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_contractLines;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file;
        private System.Windows.Forms.ToolStripMenuItem tsmi_fileExport;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_editChange;
        private System.Windows.Forms.ToolStripMenuItem tsmi_editDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_ContractLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceCipher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCipher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeliveryDate;
        private System.Windows.Forms.ProgressBar pb_export;
    }
}