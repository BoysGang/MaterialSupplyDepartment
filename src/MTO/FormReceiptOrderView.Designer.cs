
namespace MTO
{
    partial class FormReceiptOrderView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_receiptOrderNumber = new System.Windows.Forms.Label();
            this.dgv_receiptOrders = new System.Windows.Forms.DataGridView();
            this.PK_ReceiptOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseCipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderCipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_receiptOrderLines = new System.Windows.Forms.DataGridView();
            this.PK_ReceiptOrderLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceCipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pb_export = new System.Windows.Forms.ProgressBar();
            this.menuStripReceiptOrder = new System.Windows.Forms.MenuStrip();
            this.tsmi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_fileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_editChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_editDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receiptOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receiptOrderLines)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStripReceiptOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_receiptOrderNumber
            // 
            this.lbl_receiptOrderNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_receiptOrderNumber.AutoSize = true;
            this.lbl_receiptOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_receiptOrderNumber.Location = new System.Drawing.Point(298, 16);
            this.lbl_receiptOrderNumber.Name = "lbl_receiptOrderNumber";
            this.lbl_receiptOrderNumber.Size = new System.Drawing.Size(180, 20);
            this.lbl_receiptOrderNumber.TabIndex = 3;
            this.lbl_receiptOrderNumber.Text = "Приходной ордер №";
            // 
            // dgv_receiptOrders
            // 
            this.dgv_receiptOrders.AllowUserToAddRows = false;
            this.dgv_receiptOrders.AllowUserToDeleteRows = false;
            this.dgv_receiptOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_receiptOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_receiptOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_ReceiptOrder,
            this.DeliveryDate,
            this.WarehouseCipher,
            this.Provider,
            this.ProviderCipher,
            this.ContractNumber});
            this.dgv_receiptOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_receiptOrders.Location = new System.Drawing.Point(3, 56);
            this.dgv_receiptOrders.Name = "dgv_receiptOrders";
            this.dgv_receiptOrders.ReadOnly = true;
            this.dgv_receiptOrders.RowHeadersVisible = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_receiptOrders.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_receiptOrders.Size = new System.Drawing.Size(770, 73);
            this.dgv_receiptOrders.TabIndex = 4;
            this.dgv_receiptOrders.SelectionChanged += new System.EventHandler(this.dgv_receiptOrders_SelectionChanged);
            // 
            // PK_ReceiptOrder
            // 
            this.PK_ReceiptOrder.HeaderText = "PK_ReceiptOrder";
            this.PK_ReceiptOrder.Name = "PK_ReceiptOrder";
            this.PK_ReceiptOrder.ReadOnly = true;
            this.PK_ReceiptOrder.Visible = false;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.HeaderText = "Дата поставки";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ReadOnly = true;
            // 
            // WarehouseCipher
            // 
            this.WarehouseCipher.HeaderText = "Шифр склада";
            this.WarehouseCipher.Name = "WarehouseCipher";
            this.WarehouseCipher.ReadOnly = true;
            // 
            // Provider
            // 
            this.Provider.HeaderText = "Поставщик";
            this.Provider.Name = "Provider";
            this.Provider.ReadOnly = true;
            // 
            // ProviderCipher
            // 
            this.ProviderCipher.HeaderText = "Шифр поставщика";
            this.ProviderCipher.Name = "ProviderCipher";
            this.ProviderCipher.ReadOnly = true;
            // 
            // ContractNumber
            // 
            this.ContractNumber.HeaderText = "Шифр сопроводительного документа";
            this.ContractNumber.Name = "ContractNumber";
            this.ContractNumber.ReadOnly = true;
            // 
            // dgv_receiptOrderLines
            // 
            this.dgv_receiptOrderLines.AllowUserToAddRows = false;
            this.dgv_receiptOrderLines.AllowUserToDeleteRows = false;
            this.dgv_receiptOrderLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_receiptOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_receiptOrderLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_ReceiptOrderLine,
            this.ResourceName,
            this.ResourceCipher,
            this.Unit,
            this.UnitCipher,
            this.DocumentAmount,
            this.AcceptedAmount,
            this.UnitPrice,
            this.Price});
            this.dgv_receiptOrderLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_receiptOrderLines.Location = new System.Drawing.Point(3, 135);
            this.dgv_receiptOrderLines.MultiSelect = false;
            this.dgv_receiptOrderLines.Name = "dgv_receiptOrderLines";
            this.dgv_receiptOrderLines.ReadOnly = true;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_receiptOrderLines.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_receiptOrderLines.Size = new System.Drawing.Size(770, 366);
            this.dgv_receiptOrderLines.TabIndex = 5;
            this.dgv_receiptOrderLines.SelectionChanged += new System.EventHandler(this.dgv_receiptOrderLines_SelectionChanged);
            // 
            // PK_ReceiptOrderLine
            // 
            this.PK_ReceiptOrderLine.HeaderText = "PK_ReceiptOrderLine";
            this.PK_ReceiptOrderLine.Name = "PK_ReceiptOrderLine";
            this.PK_ReceiptOrderLine.ReadOnly = true;
            this.PK_ReceiptOrderLine.Visible = false;
            // 
            // ResourceName
            // 
            this.ResourceName.HeaderText = "Наименование ресурса";
            this.ResourceName.Name = "ResourceName";
            this.ResourceName.ReadOnly = true;
            // 
            // ResourceCipher
            // 
            this.ResourceCipher.HeaderText = "Шифр ресурса";
            this.ResourceCipher.Name = "ResourceCipher";
            this.ResourceCipher.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Ед. измерения";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // UnitCipher
            // 
            this.UnitCipher.HeaderText = "Шифр ед. измерения";
            this.UnitCipher.Name = "UnitCipher";
            this.UnitCipher.ReadOnly = true;
            // 
            // DocumentAmount
            // 
            this.DocumentAmount.HeaderText = "Кол-во по документу";
            this.DocumentAmount.Name = "DocumentAmount";
            this.DocumentAmount.ReadOnly = true;
            // 
            // AcceptedAmount
            // 
            this.AcceptedAmount.HeaderText = "Кол-во принято";
            this.AcceptedAmount.Name = "AcceptedAmount";
            this.AcceptedAmount.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Цена за единицу, руб.";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Общая цена, руб.";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_receiptOrders, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_receiptOrderNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_receiptOrderLines, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pb_export, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 532);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // pb_export
            // 
            this.pb_export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_export.Location = new System.Drawing.Point(3, 507);
            this.pb_export.Name = "pb_export";
            this.pb_export.Size = new System.Drawing.Size(770, 22);
            this.pb_export.TabIndex = 6;
            // 
            // menuStripReceiptOrder
            // 
            this.menuStripReceiptOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file,
            this.tsmi_edit});
            this.menuStripReceiptOrder.Location = new System.Drawing.Point(0, 0);
            this.menuStripReceiptOrder.Name = "menuStripReceiptOrder";
            this.menuStripReceiptOrder.Size = new System.Drawing.Size(776, 24);
            this.menuStripReceiptOrder.TabIndex = 7;
            this.menuStripReceiptOrder.Text = "menuStrip1";
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
            this.tsmi_fileExport.Size = new System.Drawing.Size(119, 22);
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
            this.tsmi_editChange.Size = new System.Drawing.Size(163, 22);
            this.tsmi_editChange.Text = "Редактирование";
            this.tsmi_editChange.Click += new System.EventHandler(this.tsmi_editChange_Click);
            // 
            // tsmi_editDelete
            // 
            this.tsmi_editDelete.Name = "tsmi_editDelete";
            this.tsmi_editDelete.Size = new System.Drawing.Size(163, 22);
            this.tsmi_editDelete.Text = "Удаление";
            this.tsmi_editDelete.Click += new System.EventHandler(this.tsmi_editDelete_Click);
            // 
            // FormReceiptOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 556);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStripReceiptOrder);
            this.Name = "FormReceiptOrderView";
            this.Text = "Просмотр приходного ордера";
            this.Activated += new System.EventHandler(this.FormReceiptOrderView_Activated);
            this.Load += new System.EventHandler(this.FormReceiptOrderView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receiptOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receiptOrderLines)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStripReceiptOrder.ResumeLayout(false);
            this.menuStripReceiptOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_receiptOrderNumber;
        private System.Windows.Forms.DataGridView dgv_receiptOrders;
        private System.Windows.Forms.DataGridView dgv_receiptOrderLines;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStripReceiptOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file;
        private System.Windows.Forms.ToolStripMenuItem tsmi_fileExport;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_editChange;
        private System.Windows.Forms.ToolStripMenuItem tsmi_editDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_ReceiptOrderLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceCipher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCipher;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcceptedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_ReceiptOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseCipher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProviderCipher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractNumber;
        private System.Windows.Forms.ProgressBar pb_export;
    }
}