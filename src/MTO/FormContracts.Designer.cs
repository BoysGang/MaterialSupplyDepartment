
namespace MTO
{
    partial class FormContracts
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_provider = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_conclusionDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_expiredDate = new System.Windows.Forms.DateTimePicker();
            this.dgv_contracts = new System.Windows.Forms.DataGridView();
            this.PK_Contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConclusionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderAgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Underdelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_contractNumber = new System.Windows.Forms.ComboBox();
            this.rb_closed = new System.Windows.Forms.RadioButton();
            this.rb_opened = new System.Windows.Forms.RadioButton();
            this.rb_any = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_findContracts = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btn_analizeContract = new System.Windows.Forms.Button();
            this.btn_viewContract = new System.Windows.Forms.Button();
            this.btn_resetSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contracts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Номер договора";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // cb_provider
            // 
            this.cb_provider.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_provider.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_provider.FormattingEnabled = true;
            this.cb_provider.Location = new System.Drawing.Point(113, 54);
            this.cb_provider.Name = "cb_provider";
            this.cb_provider.Size = new System.Drawing.Size(363, 21);
            this.cb_provider.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Дата окончания";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_conclusionDate
            // 
            this.dtp_conclusionDate.CustomFormat = " ";
            this.dtp_conclusionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_conclusionDate.Location = new System.Drawing.Point(112, 88);
            this.dtp_conclusionDate.Name = "dtp_conclusionDate";
            this.dtp_conclusionDate.Size = new System.Drawing.Size(364, 20);
            this.dtp_conclusionDate.TabIndex = 24;
            this.dtp_conclusionDate.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            this.dtp_conclusionDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker3_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Дата заключения";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_expiredDate
            // 
            this.dtp_expiredDate.CustomFormat = " ";
            this.dtp_expiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_expiredDate.Location = new System.Drawing.Point(112, 160);
            this.dtp_expiredDate.Name = "dtp_expiredDate";
            this.dtp_expiredDate.Size = new System.Drawing.Size(364, 20);
            this.dtp_expiredDate.TabIndex = 25;
            this.dtp_expiredDate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.dtp_expiredDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker2_KeyDown);
            // 
            // dgv_contracts
            // 
            this.dgv_contracts.AllowUserToAddRows = false;
            this.dgv_contracts.AllowUserToDeleteRows = false;
            this.dgv_contracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_contracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_Contract,
            this.ContractNumber,
            this.ConclusionDate,
            this.StartDate,
            this.ExpiredDate,
            this.ProviderAgent,
            this.State,
            this.Underdelivery});
            this.dgv_contracts.Location = new System.Drawing.Point(6, 324);
            this.dgv_contracts.MultiSelect = false;
            this.dgv_contracts.Name = "dgv_contracts";
            this.dgv_contracts.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_contracts.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_contracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_contracts.Size = new System.Drawing.Size(897, 235);
            this.dgv_contracts.TabIndex = 23;
            this.dgv_contracts.SelectionChanged += new System.EventHandler(this.dgv_contracts_SelectionChanged);
            // 
            // PK_Contract
            // 
            this.PK_Contract.HeaderText = "PK_Contract";
            this.PK_Contract.Name = "PK_Contract";
            this.PK_Contract.ReadOnly = true;
            this.PK_Contract.Visible = false;
            // 
            // ContractNumber
            // 
            this.ContractNumber.HeaderText = "Номер договора";
            this.ContractNumber.Name = "ContractNumber";
            this.ContractNumber.ReadOnly = true;
            // 
            // ConclusionDate
            // 
            this.ConclusionDate.HeaderText = "Дата заключения";
            this.ConclusionDate.Name = "ConclusionDate";
            this.ConclusionDate.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Дата начала";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // ExpiredDate
            // 
            this.ExpiredDate.HeaderText = "Дата окончания";
            this.ExpiredDate.Name = "ExpiredDate";
            this.ExpiredDate.ReadOnly = true;
            // 
            // ProviderAgent
            // 
            this.ProviderAgent.HeaderText = "Поставщик";
            this.ProviderAgent.Name = "ProviderAgent";
            this.ProviderAgent.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "Статус";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // Underdelivery
            // 
            this.Underdelivery.HeaderText = "Недопоставки";
            this.Underdelivery.Name = "Underdelivery";
            this.Underdelivery.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_startDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_contractNumber);
            this.groupBox1.Controls.Add(this.rb_closed);
            this.groupBox1.Controls.Add(this.rb_opened);
            this.groupBox1.Controls.Add(this.rb_any);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtp_expiredDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_provider);
            this.groupBox1.Controls.Add(this.dtp_conclusionDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 234);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры поиска";
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.CustomFormat = " ";
            this.dtp_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_startDate.Location = new System.Drawing.Point(112, 124);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(364, 20);
            this.dtp_startDate.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Дата начала";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_contractNumber
            // 
            this.cb_contractNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_contractNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_contractNumber.FormattingEnabled = true;
            this.cb_contractNumber.Location = new System.Drawing.Point(113, 19);
            this.cb_contractNumber.Name = "cb_contractNumber";
            this.cb_contractNumber.Size = new System.Drawing.Size(363, 21);
            this.cb_contractNumber.TabIndex = 36;
            // 
            // rb_closed
            // 
            this.rb_closed.AutoSize = true;
            this.rb_closed.Location = new System.Drawing.Point(413, 200);
            this.rb_closed.Name = "rb_closed";
            this.rb_closed.Size = new System.Drawing.Size(63, 17);
            this.rb_closed.TabIndex = 35;
            this.rb_closed.Text = "Закрыт";
            this.rb_closed.UseVisualStyleBackColor = true;
            // 
            // rb_opened
            // 
            this.rb_opened.AutoSize = true;
            this.rb_opened.Location = new System.Drawing.Point(260, 200);
            this.rb_opened.Name = "rb_opened";
            this.rb_opened.Size = new System.Drawing.Size(63, 17);
            this.rb_opened.TabIndex = 34;
            this.rb_opened.Text = "Открыт";
            this.rb_opened.UseVisualStyleBackColor = true;
            // 
            // rb_any
            // 
            this.rb_any.AutoSize = true;
            this.rb_any.Checked = true;
            this.rb_any.Location = new System.Drawing.Point(112, 200);
            this.rb_any.Name = "rb_any";
            this.rb_any.Size = new System.Drawing.Size(59, 17);
            this.rb_any.TabIndex = 33;
            this.rb_any.TabStop = true;
            this.rb_any.Text = "Любой";
            this.rb_any.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Статус договора";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_findContracts
            // 
            this.btn_findContracts.Location = new System.Drawing.Point(6, 276);
            this.btn_findContracts.Name = "btn_findContracts";
            this.btn_findContracts.Size = new System.Drawing.Size(238, 33);
            this.btn_findContracts.TabIndex = 33;
            this.btn_findContracts.Text = "Найти";
            this.btn_findContracts.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(494, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 234);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация";
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
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_contracts,
            this.tsmi_accounting,
            this.tsmi_dict});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(908, 24);
            this.menuStrip.TabIndex = 35;
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
            this.tsmi_ContractSearch.Visible = false;
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
            this.tsmi_accountingReceiptOrderList.Click += new System.EventHandler(this.tsmi_accountingReceiptOrderList_Click);
            // 
            // tsmi_accountingReceiptOrderAdd
            // 
            this.tsmi_accountingReceiptOrderAdd.Name = "tsmi_accountingReceiptOrderAdd";
            this.tsmi_accountingReceiptOrderAdd.Size = new System.Drawing.Size(252, 22);
            this.tsmi_accountingReceiptOrderAdd.Text = "Добавление приходного оредра";
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
            // btn_analizeContract
            // 
            this.btn_analizeContract.Location = new System.Drawing.Point(494, 276);
            this.btn_analizeContract.Name = "btn_analizeContract";
            this.btn_analizeContract.Size = new System.Drawing.Size(202, 33);
            this.btn_analizeContract.TabIndex = 36;
            this.btn_analizeContract.Text = "Анализ";
            this.btn_analizeContract.UseVisualStyleBackColor = true;
            this.btn_analizeContract.Click += new System.EventHandler(this.btn_analizeContract_Click);
            // 
            // btn_viewContract
            // 
            this.btn_viewContract.Location = new System.Drawing.Point(701, 276);
            this.btn_viewContract.Name = "btn_viewContract";
            this.btn_viewContract.Size = new System.Drawing.Size(202, 33);
            this.btn_viewContract.TabIndex = 37;
            this.btn_viewContract.Text = "Просмотр";
            this.btn_viewContract.UseVisualStyleBackColor = true;
            this.btn_viewContract.Click += new System.EventHandler(this.btn_viewContract_Click);
            // 
            // btn_resetSearch
            // 
            this.btn_resetSearch.Location = new System.Drawing.Point(250, 276);
            this.btn_resetSearch.Name = "btn_resetSearch";
            this.btn_resetSearch.Size = new System.Drawing.Size(238, 33);
            this.btn_resetSearch.TabIndex = 38;
            this.btn_resetSearch.Text = "Сбросить фильтры";
            this.btn_resetSearch.UseVisualStyleBackColor = true;
            this.btn_resetSearch.Click += new System.EventHandler(this.btn_resetSearch_Click);
            // 
            // FormContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 571);
            this.Controls.Add(this.btn_resetSearch);
            this.Controls.Add(this.btn_viewContract);
            this.Controls.Add(this.btn_findContracts);
            this.Controls.Add(this.btn_analizeContract);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_contracts);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FormContracts";
            this.Text = "Модуль договоров";
            this.Activated += new System.EventHandler(this.FormContracts_Activated);
            this.Load += new System.EventHandler(this.FormContracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contracts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_provider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_conclusionDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_expiredDate;
        private System.Windows.Forms.DataGridView dgv_contracts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_findContracts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.RadioButton rb_closed;
        private System.Windows.Forms.RadioButton rb_opened;
        private System.Windows.Forms.RadioButton rb_any;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_analizeContract;
        private System.Windows.Forms.Button btn_viewContract;
        private System.Windows.Forms.ComboBox cb_contractNumber;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_resetSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_Contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConclusionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProviderAgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Underdelivery;
        private System.Windows.Forms.ToolStripMenuItem tsmi_accountingReceiptOrderList;
        private System.Windows.Forms.ToolStripMenuItem tsmi_accountingReceiptOrderAdd;
    }
}