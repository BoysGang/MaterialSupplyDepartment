
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
            this.dtp_expiredDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dgv_contracts = new System.Windows.Forms.DataGridView();
            this.PK_Contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConclusionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderAgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConclusionCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_resource = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_conclusionCity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_hasUnderdelivery = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.dtp_expiredDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtp_startDateTo = new System.Windows.Forms.DateTimePicker();
            this.tb_contractNumber = new System.Windows.Forms.TextBox();
            this.dtp_startDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_closed = new System.Windows.Forms.RadioButton();
            this.rb_opened = new System.Windows.Forms.RadioButton();
            this.rb_any = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_findContracts = new System.Windows.Forms.Button();
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
            this.pb_updateTable = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contracts)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.label6.Location = new System.Drawing.Point(493, 23);
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
            this.cb_provider.Location = new System.Drawing.Point(599, 19);
            this.cb_provider.Name = "cb_provider";
            this.cb_provider.Size = new System.Drawing.Size(284, 21);
            this.cb_provider.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Дата окончания c";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_conclusionDate
            // 
            this.dtp_conclusionDate.CustomFormat = " ";
            this.dtp_conclusionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_conclusionDate.Location = new System.Drawing.Point(112, 54);
            this.dtp_conclusionDate.Name = "dtp_conclusionDate";
            this.dtp_conclusionDate.Size = new System.Drawing.Size(284, 20);
            this.dtp_conclusionDate.TabIndex = 24;
            this.dtp_conclusionDate.ValueChanged += new System.EventHandler(this.dtp_conclusionDate_ValueChanged);
            this.dtp_conclusionDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_conclusionDate_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Дата заключения";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_expiredDateFrom
            // 
            this.dtp_expiredDateFrom.CustomFormat = " ";
            this.dtp_expiredDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_expiredDateFrom.Location = new System.Drawing.Point(112, 124);
            this.dtp_expiredDateFrom.Name = "dtp_expiredDateFrom";
            this.dtp_expiredDateFrom.Size = new System.Drawing.Size(127, 20);
            this.dtp_expiredDateFrom.TabIndex = 25;
            this.dtp_expiredDateFrom.ValueChanged += new System.EventHandler(this.dtp_expiredDate_ValueChanged);
            this.dtp_expiredDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_expiredDate_KeyDown);
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
            this.ConclusionCity,
            this.State});
            this.dgv_contracts.Location = new System.Drawing.Point(6, 275);
            this.dgv_contracts.MultiSelect = false;
            this.dgv_contracts.Name = "dgv_contracts";
            this.dgv_contracts.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_contracts.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_contracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_contracts.Size = new System.Drawing.Size(897, 322);
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
            // ConclusionCity
            // 
            this.ConclusionCity.HeaderText = "Место заключения";
            this.ConclusionCity.Name = "ConclusionCity";
            this.ConclusionCity.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "Статус";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_resource);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tb_conclusionCity);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cb_hasUnderdelivery);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label69);
            this.groupBox1.Controls.Add(this.dtp_expiredDateTo);
            this.groupBox1.Controls.Add(this.dtp_startDateTo);
            this.groupBox1.Controls.Add(this.tb_contractNumber);
            this.groupBox1.Controls.Add(this.cb_provider);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtp_startDateFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rb_closed);
            this.groupBox1.Controls.Add(this.rb_opened);
            this.groupBox1.Controls.Add(this.rb_any);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtp_expiredDateFrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtp_conclusionDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 192);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры поиска";
            // 
            // cb_resource
            // 
            this.cb_resource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_resource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_resource.FormattingEnabled = true;
            this.cb_resource.Location = new System.Drawing.Point(599, 54);
            this.cb_resource.Name = "cb_resource";
            this.cb_resource.Size = new System.Drawing.Size(284, 21);
            this.cb_resource.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(493, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Ресурс";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_conclusionCity
            // 
            this.tb_conclusionCity.Location = new System.Drawing.Point(599, 90);
            this.tb_conclusionCity.MaxLength = 50;
            this.tb_conclusionCity.Name = "tb_conclusionCity";
            this.tb_conclusionCity.Size = new System.Drawing.Size(284, 20);
            this.tb_conclusionCity.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(493, 93);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Место заключения";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_hasUnderdelivery
            // 
            this.cb_hasUnderdelivery.AutoSize = true;
            this.cb_hasUnderdelivery.Location = new System.Drawing.Point(599, 161);
            this.cb_hasUnderdelivery.Name = "cb_hasUnderdelivery";
            this.cb_hasUnderdelivery.Size = new System.Drawing.Size(50, 17);
            this.cb_hasUnderdelivery.TabIndex = 47;
            this.cb_hasUnderdelivery.Text = "Есть";
            this.cb_hasUnderdelivery.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "до";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "до";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(493, 162);
            this.label69.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(80, 13);
            this.label69.TabIndex = 42;
            this.label69.Text = "Недопоставки";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_expiredDateTo
            // 
            this.dtp_expiredDateTo.CustomFormat = " ";
            this.dtp_expiredDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_expiredDateTo.Location = new System.Drawing.Point(270, 124);
            this.dtp_expiredDateTo.Name = "dtp_expiredDateTo";
            this.dtp_expiredDateTo.Size = new System.Drawing.Size(126, 20);
            this.dtp_expiredDateTo.TabIndex = 41;
            this.dtp_expiredDateTo.ValueChanged += new System.EventHandler(this.dtp_expiredDateTo_ValueChanged);
            this.dtp_expiredDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_expiredDateTo_KeyDown);
            // 
            // dtp_startDateTo
            // 
            this.dtp_startDateTo.CustomFormat = " ";
            this.dtp_startDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_startDateTo.Location = new System.Drawing.Point(269, 89);
            this.dtp_startDateTo.Name = "dtp_startDateTo";
            this.dtp_startDateTo.Size = new System.Drawing.Size(127, 20);
            this.dtp_startDateTo.TabIndex = 40;
            this.dtp_startDateTo.ValueChanged += new System.EventHandler(this.dtp_startDateTo_ValueChanged);
            this.dtp_startDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_startDateTo_KeyDown);
            // 
            // tb_contractNumber
            // 
            this.tb_contractNumber.Location = new System.Drawing.Point(112, 19);
            this.tb_contractNumber.MaxLength = 50;
            this.tb_contractNumber.Name = "tb_contractNumber";
            this.tb_contractNumber.Size = new System.Drawing.Size(284, 20);
            this.tb_contractNumber.TabIndex = 39;
            this.tb_contractNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_contractNumber_KeyPress);
            // 
            // dtp_startDateFrom
            // 
            this.dtp_startDateFrom.CustomFormat = " ";
            this.dtp_startDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_startDateFrom.Location = new System.Drawing.Point(112, 89);
            this.dtp_startDateFrom.Name = "dtp_startDateFrom";
            this.dtp_startDateFrom.Size = new System.Drawing.Size(127, 20);
            this.dtp_startDateFrom.TabIndex = 37;
            this.dtp_startDateFrom.ValueChanged += new System.EventHandler(this.dtp_startDate_ValueChanged);
            this.dtp_startDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_startDate_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Дата начала c";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_closed
            // 
            this.rb_closed.AutoSize = true;
            this.rb_closed.Location = new System.Drawing.Point(820, 127);
            this.rb_closed.Name = "rb_closed";
            this.rb_closed.Size = new System.Drawing.Size(63, 17);
            this.rb_closed.TabIndex = 35;
            this.rb_closed.Text = "Закрыт";
            this.rb_closed.UseVisualStyleBackColor = true;
            // 
            // rb_opened
            // 
            this.rb_opened.AutoSize = true;
            this.rb_opened.Location = new System.Drawing.Point(700, 127);
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
            this.rb_any.Location = new System.Drawing.Point(599, 127);
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
            this.label2.Location = new System.Drawing.Point(493, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Статус договора";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_findContracts
            // 
            this.btn_findContracts.Location = new System.Drawing.Point(6, 236);
            this.btn_findContracts.Name = "btn_findContracts";
            this.btn_findContracts.Size = new System.Drawing.Size(238, 33);
            this.btn_findContracts.TabIndex = 33;
            this.btn_findContracts.Text = "Найти";
            this.btn_findContracts.UseVisualStyleBackColor = true;
            this.btn_findContracts.Click += new System.EventHandler(this.btn_findContracts_Click);
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
            this.btn_analizeContract.Location = new System.Drawing.Point(494, 236);
            this.btn_analizeContract.Name = "btn_analizeContract";
            this.btn_analizeContract.Size = new System.Drawing.Size(202, 33);
            this.btn_analizeContract.TabIndex = 36;
            this.btn_analizeContract.Text = "Анализ";
            this.btn_analizeContract.UseVisualStyleBackColor = true;
            this.btn_analizeContract.Click += new System.EventHandler(this.btn_analizeContract_Click);
            // 
            // btn_viewContract
            // 
            this.btn_viewContract.Location = new System.Drawing.Point(701, 236);
            this.btn_viewContract.Name = "btn_viewContract";
            this.btn_viewContract.Size = new System.Drawing.Size(202, 33);
            this.btn_viewContract.TabIndex = 37;
            this.btn_viewContract.Text = "Просмотр";
            this.btn_viewContract.UseVisualStyleBackColor = true;
            this.btn_viewContract.Click += new System.EventHandler(this.btn_viewContract_Click);
            // 
            // btn_resetSearch
            // 
            this.btn_resetSearch.Location = new System.Drawing.Point(250, 236);
            this.btn_resetSearch.Name = "btn_resetSearch";
            this.btn_resetSearch.Size = new System.Drawing.Size(238, 33);
            this.btn_resetSearch.TabIndex = 38;
            this.btn_resetSearch.Text = "Сбросить фильтры";
            this.btn_resetSearch.UseVisualStyleBackColor = true;
            this.btn_resetSearch.Click += new System.EventHandler(this.btn_resetSearch_Click);
            // 
            // pb_updateTable
            // 
            this.pb_updateTable.Location = new System.Drawing.Point(6, 600);
            this.pb_updateTable.Name = "pb_updateTable";
            this.pb_updateTable.Size = new System.Drawing.Size(897, 24);
            this.pb_updateTable.TabIndex = 39;
            // 
            // FormContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 626);
            this.Controls.Add(this.pb_updateTable);
            this.Controls.Add(this.btn_resetSearch);
            this.Controls.Add(this.btn_viewContract);
            this.Controls.Add(this.btn_findContracts);
            this.Controls.Add(this.btn_analizeContract);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_contracts);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FormContracts";
            this.Text = "Модуль договоров";
            this.Load += new System.EventHandler(this.FormContracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contracts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dtp_expiredDateFrom;
        private System.Windows.Forms.DataGridView dgv_contracts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_findContracts;
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
        private System.Windows.Forms.DateTimePicker dtp_startDateFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_resetSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmi_accountingReceiptOrderList;
        private System.Windows.Forms.ToolStripMenuItem tsmi_accountingReceiptOrderAdd;
        private System.Windows.Forms.TextBox tb_contractNumber;
        private System.Windows.Forms.DateTimePicker dtp_startDateTo;
        private System.Windows.Forms.CheckBox cb_hasUnderdelivery;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.DateTimePicker dtp_expiredDateTo;
        private System.Windows.Forms.TextBox tb_conclusionCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_resource;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_Contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConclusionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProviderAgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConclusionCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.ProgressBar pb_updateTable;
    }
}