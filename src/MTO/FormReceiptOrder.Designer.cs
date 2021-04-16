
namespace MTO
{
    partial class FormReceiptOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_receiptOrders = new System.Windows.Forms.DataGridView();
            this.PK_ReceiptOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderAgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_provider = new System.Windows.Forms.ComboBox();
            this.dtp_deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_receiptOrderNumber = new System.Windows.Forms.TextBox();
            this.btn_findReceiptOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_contractNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_warehouse = new System.Windows.Forms.ComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmi_contracts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ContractSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_contractCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_accounting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_accountingReceiptOrderList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_accountingReceiptOrderAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_dict = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_dictResources = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_dictUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_dictProvider = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_dictWarehouses = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_viewReceiptOrder = new System.Windows.Forms.Button();
            this.btn_resetSearch = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receiptOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поля необязательны к заполнению. \r\nВы можете выбрать только интересующие Вас пара" +
    "метры, \r\nбудь то номер договора или поставщик.\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(500, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 199);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация";
            // 
            // dgv_receiptOrders
            // 
            this.dgv_receiptOrders.AllowUserToAddRows = false;
            this.dgv_receiptOrders.AllowUserToDeleteRows = false;
            this.dgv_receiptOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_receiptOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_receiptOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_ReceiptOrder,
            this.ReceiptOrderNumber,
            this.DeliveryDate,
            this.Warehouse,
            this.ProviderAgent,
            this.Contract});
            this.dgv_receiptOrders.Location = new System.Drawing.Point(12, 285);
            this.dgv_receiptOrders.MultiSelect = false;
            this.dgv_receiptOrders.Name = "dgv_receiptOrders";
            this.dgv_receiptOrders.ReadOnly = true;
            this.dgv_receiptOrders.RowHeadersWidth = 51;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_receiptOrders.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_receiptOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_receiptOrders.Size = new System.Drawing.Size(898, 244);
            this.dgv_receiptOrders.TabIndex = 36;
            this.dgv_receiptOrders.SelectionChanged += new System.EventHandler(this.dgv_receiptOrders_SelectionChanged);
            // 
            // PK_ReceiptOrder
            // 
            this.PK_ReceiptOrder.HeaderText = "PK_ReceiptOrder";
            this.PK_ReceiptOrder.Name = "PK_ReceiptOrder";
            this.PK_ReceiptOrder.ReadOnly = true;
            this.PK_ReceiptOrder.Visible = false;
            // 
            // ReceiptOrderNumber
            // 
            this.ReceiptOrderNumber.HeaderText = "Номер приходного ордера";
            this.ReceiptOrderNumber.MinimumWidth = 6;
            this.ReceiptOrderNumber.Name = "ReceiptOrderNumber";
            this.ReceiptOrderNumber.ReadOnly = true;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.HeaderText = "Дата поставки";
            this.DeliveryDate.MinimumWidth = 6;
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ReadOnly = true;
            // 
            // Warehouse
            // 
            this.Warehouse.HeaderText = "Шифр склада";
            this.Warehouse.MinimumWidth = 6;
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.ReadOnly = true;
            // 
            // ProviderAgent
            // 
            this.ProviderAgent.HeaderText = "Поставщик";
            this.ProviderAgent.MinimumWidth = 6;
            this.ProviderAgent.Name = "ProviderAgent";
            this.ProviderAgent.ReadOnly = true;
            // 
            // Contract
            // 
            this.Contract.HeaderText = "Номер договора";
            this.Contract.MinimumWidth = 6;
            this.Contract.Name = "Contract";
            this.Contract.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Номер ордера";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Шифр склада";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_provider
            // 
            this.cb_provider.FormattingEnabled = true;
            this.cb_provider.Location = new System.Drawing.Point(112, 54);
            this.cb_provider.Name = "cb_provider";
            this.cb_provider.Size = new System.Drawing.Size(364, 21);
            this.cb_provider.TabIndex = 27;
            // 
            // dtp_deliveryDate
            // 
            this.dtp_deliveryDate.CustomFormat = " ";
            this.dtp_deliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_deliveryDate.Location = new System.Drawing.Point(112, 88);
            this.dtp_deliveryDate.Name = "dtp_deliveryDate";
            this.dtp_deliveryDate.Size = new System.Drawing.Size(364, 20);
            this.dtp_deliveryDate.TabIndex = 24;
            this.dtp_deliveryDate.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            this.dtp_deliveryDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker3_KeyDown);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Поставщик";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Дата поставки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_receiptOrderNumber
            // 
            this.tb_receiptOrderNumber.Location = new System.Drawing.Point(112, 22);
            this.tb_receiptOrderNumber.MaxLength = 50;
            this.tb_receiptOrderNumber.Name = "tb_receiptOrderNumber";
            this.tb_receiptOrderNumber.Size = new System.Drawing.Size(364, 20);
            this.tb_receiptOrderNumber.TabIndex = 26;
            this.tb_receiptOrderNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_receiptOrder_KeyPress);
            // 
            // btn_findReceiptOrder
            // 
            this.btn_findReceiptOrder.Location = new System.Drawing.Point(12, 232);
            this.btn_findReceiptOrder.Name = "btn_findReceiptOrder";
            this.btn_findReceiptOrder.Size = new System.Drawing.Size(238, 33);
            this.btn_findReceiptOrder.TabIndex = 38;
            this.btn_findReceiptOrder.Text = "Найти";
            this.btn_findReceiptOrder.UseVisualStyleBackColor = true;
            this.btn_findReceiptOrder.Click += new System.EventHandler(this.btn_findReceiptOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_contractNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_warehouse);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_provider);
            this.groupBox1.Controls.Add(this.dtp_deliveryDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_receiptOrderNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 199);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры поиска";
            // 
            // tb_contractNumber
            // 
            this.tb_contractNumber.Location = new System.Drawing.Point(112, 155);
            this.tb_contractNumber.MaxLength = 50;
            this.tb_contractNumber.Name = "tb_contractNumber";
            this.tb_contractNumber.Size = new System.Drawing.Size(364, 20);
            this.tb_contractNumber.TabIndex = 34;
            this.tb_contractNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_contract_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Номер договора";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_warehouse
            // 
            this.cb_warehouse.FormattingEnabled = true;
            this.cb_warehouse.Location = new System.Drawing.Point(112, 120);
            this.cb_warehouse.Name = "cb_warehouse";
            this.cb_warehouse.Size = new System.Drawing.Size(364, 21);
            this.cb_warehouse.TabIndex = 32;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_contracts,
            this.tsmi_accounting,
            this.tsmi_dict});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(924, 24);
            this.menuStrip.TabIndex = 40;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmi_contracts
            // 
            this.tsmi_contracts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ContractSearch,
            this.tsmi_contractCreate});
            this.tsmi_contracts.Name = "tsmi_contracts";
            this.tsmi_contracts.Size = new System.Drawing.Size(72, 20);
            this.tsmi_contracts.Text = "Договора";
            // 
            // tsmi_ContractSearch
            // 
            this.tsmi_ContractSearch.Name = "tsmi_ContractSearch";
            this.tsmi_ContractSearch.Size = new System.Drawing.Size(141, 22);
            this.tsmi_ContractSearch.Text = "Список";
            this.tsmi_ContractSearch.Click += new System.EventHandler(this.tsmi_ContractSearch_Click);
            // 
            // tsmi_contractCreate
            // 
            this.tsmi_contractCreate.Name = "tsmi_contractCreate";
            this.tsmi_contractCreate.Size = new System.Drawing.Size(141, 22);
            this.tsmi_contractCreate.Text = "Добавление";
            this.tsmi_contractCreate.Click += new System.EventHandler(this.tsmi_contractCreate_Click);
            // 
            // tsmi_accounting
            // 
            this.tsmi_accounting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_accountingReceiptOrderList,
            this.tsmi_accountingReceiptOrderAdd});
            this.tsmi_accounting.Name = "tsmi_accounting";
            this.tsmi_accounting.Size = new System.Drawing.Size(44, 20);
            this.tsmi_accounting.Text = "Учет";
            // 
            // tsmi_accountingReceiptOrderList
            // 
            this.tsmi_accountingReceiptOrderList.Name = "tsmi_accountingReceiptOrderList";
            this.tsmi_accountingReceiptOrderList.Size = new System.Drawing.Size(252, 22);
            this.tsmi_accountingReceiptOrderList.Text = "Список приходных ордеров";
            this.tsmi_accountingReceiptOrderList.Visible = false;
            // 
            // tsmi_accountingReceiptOrderAdd
            // 
            this.tsmi_accountingReceiptOrderAdd.Name = "tsmi_accountingReceiptOrderAdd";
            this.tsmi_accountingReceiptOrderAdd.Size = new System.Drawing.Size(252, 22);
            this.tsmi_accountingReceiptOrderAdd.Text = "Добавление приходного ордера";
            this.tsmi_accountingReceiptOrderAdd.Click += new System.EventHandler(this.tsmi_accountingReceiptOrderAdd_Click);
            // 
            // tsmi_dict
            // 
            this.tsmi_dict.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_dictResources,
            this.tsmi_dictUnit,
            this.tsmi_dictProvider,
            this.tsmi_dictWarehouses});
            this.tsmi_dict.Name = "tsmi_dict";
            this.tsmi_dict.Size = new System.Drawing.Size(94, 20);
            this.tsmi_dict.Text = "Справочники";
            // 
            // tsmi_dictResources
            // 
            this.tsmi_dictResources.Name = "tsmi_dictResources";
            this.tsmi_dictResources.Size = new System.Drawing.Size(152, 22);
            this.tsmi_dictResources.Text = "Ресурсы";
            this.tsmi_dictResources.Click += new System.EventHandler(this.tsmi_dictResources_Click);
            // 
            // tsmi_dictUnit
            // 
            this.tsmi_dictUnit.Name = "tsmi_dictUnit";
            this.tsmi_dictUnit.Size = new System.Drawing.Size(152, 22);
            this.tsmi_dictUnit.Text = "Ед. измерения";
            this.tsmi_dictUnit.Click += new System.EventHandler(this.tsmi_dictUnit_Click);
            // 
            // tsmi_dictProvider
            // 
            this.tsmi_dictProvider.Name = "tsmi_dictProvider";
            this.tsmi_dictProvider.Size = new System.Drawing.Size(152, 22);
            this.tsmi_dictProvider.Text = "Поставщики";
            this.tsmi_dictProvider.Click += new System.EventHandler(this.tsmi_dictProvider_Click);
            // 
            // tsmi_dictWarehouses
            // 
            this.tsmi_dictWarehouses.Name = "tsmi_dictWarehouses";
            this.tsmi_dictWarehouses.Size = new System.Drawing.Size(152, 22);
            this.tsmi_dictWarehouses.Text = "Склады";
            this.tsmi_dictWarehouses.Click += new System.EventHandler(this.tsmi_dictWarehouses_Click);
            // 
            // btn_viewReceiptOrder
            // 
            this.btn_viewReceiptOrder.Location = new System.Drawing.Point(500, 232);
            this.btn_viewReceiptOrder.Name = "btn_viewReceiptOrder";
            this.btn_viewReceiptOrder.Size = new System.Drawing.Size(410, 33);
            this.btn_viewReceiptOrder.TabIndex = 41;
            this.btn_viewReceiptOrder.Text = "Просмотр";
            this.btn_viewReceiptOrder.UseVisualStyleBackColor = true;
            this.btn_viewReceiptOrder.Click += new System.EventHandler(this.btn_viewReceiptOrder_Click);
            // 
            // btn_resetSearch
            // 
            this.btn_resetSearch.Location = new System.Drawing.Point(256, 232);
            this.btn_resetSearch.Name = "btn_resetSearch";
            this.btn_resetSearch.Size = new System.Drawing.Size(238, 33);
            this.btn_resetSearch.TabIndex = 42;
            this.btn_resetSearch.Text = "Сбросить фильтры";
            this.btn_resetSearch.UseVisualStyleBackColor = true;
            this.btn_resetSearch.Click += new System.EventHandler(this.btn_resetSearch_Click);
            // 
            // FormReceiptOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 541);
            this.Controls.Add(this.btn_resetSearch);
            this.Controls.Add(this.btn_viewReceiptOrder);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_receiptOrders);
            this.Controls.Add(this.btn_findReceiptOrder);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReceiptOrder";
            this.Text = "Приходный ордер";
            this.Load += new System.EventHandler(this.FormReceiptOrder_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receiptOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_receiptOrders;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_provider;
        private System.Windows.Forms.DateTimePicker dtp_deliveryDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_receiptOrderNumber;
        private System.Windows.Forms.Button btn_findReceiptOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_contractNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_warehouse;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmi_contracts;
        private System.Windows.Forms.ToolStripMenuItem tsmi_contractCreate;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ContractSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmi_dict;
        private System.Windows.Forms.ToolStripMenuItem tsmi_dictResources;
        private System.Windows.Forms.ToolStripMenuItem tsmi_dictUnit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_dictProvider;
        private System.Windows.Forms.ToolStripMenuItem tsmi_dictWarehouses;
        private System.Windows.Forms.ToolStripMenuItem tsmi_accounting;
        private System.Windows.Forms.Button btn_viewReceiptOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_ReceiptOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProviderAgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contract;
        private System.Windows.Forms.ToolStripMenuItem tsmi_accountingReceiptOrderList;
        private System.Windows.Forms.ToolStripMenuItem tsmi_accountingReceiptOrderAdd;
        private System.Windows.Forms.Button btn_resetSearch;
    }
}