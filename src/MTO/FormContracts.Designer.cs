
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ContractNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConclusionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderAgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Underdelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContractCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContractSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DictToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DictResourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DictUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DictProviderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DictWarehousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountingReceiptOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountingReceiptOrderListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountingReceiptOrderAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(363, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Дата истечения";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = " ";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(112, 88);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(364, 20);
            this.dateTimePicker3.TabIndex = 24;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            this.dateTimePicker3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker3_KeyDown);
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = " ";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(112, 123);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(364, 20);
            this.dateTimePicker2.TabIndex = 25;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.dateTimePicker2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker2_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContractNumber,
            this.ConclusionDate,
            this.ExpiredDate,
            this.ProviderAgent,
            this.State,
            this.Underdelivery});
            this.dataGridView1.Location = new System.Drawing.Point(6, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(897, 235);
            this.dataGridView1.TabIndex = 23;
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
            // ExpiredDate
            // 
            this.ExpiredDate.HeaderText = "Дата истечения";
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
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 184);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры поиска";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(413, 156);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(63, 17);
            this.radioButton3.TabIndex = 35;
            this.radioButton3.Text = "Закрыт";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(260, 156);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.Text = "Открыт";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(112, 156);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Любой";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Статус договора";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(482, 33);
            this.button1.TabIndex = 33;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(494, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 184);
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
            this.ContractToolStripMenuItem,
            this.DictToolStripMenuItem,
            this.AccountingToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(908, 24);
            this.menuStrip.TabIndex = 35;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ContractToolStripMenuItem
            // 
            this.ContractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContractCreateToolStripMenuItem,
            this.ContractSearchToolStripMenuItem});
            this.ContractToolStripMenuItem.Name = "ContractToolStripMenuItem";
            this.ContractToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.ContractToolStripMenuItem.Text = "Договора";
            // 
            // ContractCreateToolStripMenuItem
            // 
            this.ContractCreateToolStripMenuItem.Name = "ContractCreateToolStripMenuItem";
            this.ContractCreateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ContractCreateToolStripMenuItem.Text = "Добавление";
            // 
            // ContractSearchToolStripMenuItem
            // 
            this.ContractSearchToolStripMenuItem.Name = "ContractSearchToolStripMenuItem";
            this.ContractSearchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ContractSearchToolStripMenuItem.Text = "Поиск";
            // 
            // DictToolStripMenuItem
            // 
            this.DictToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DictResourcesToolStripMenuItem,
            this.DictUnitToolStripMenuItem,
            this.DictProviderToolStripMenuItem,
            this.DictWarehousesToolStripMenuItem});
            this.DictToolStripMenuItem.Name = "DictToolStripMenuItem";
            this.DictToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.DictToolStripMenuItem.Text = "Справочники";
            // 
            // DictResourcesToolStripMenuItem
            // 
            this.DictResourcesToolStripMenuItem.Name = "DictResourcesToolStripMenuItem";
            this.DictResourcesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DictResourcesToolStripMenuItem.Text = "Ресурсы";
            // 
            // DictUnitToolStripMenuItem
            // 
            this.DictUnitToolStripMenuItem.Name = "DictUnitToolStripMenuItem";
            this.DictUnitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DictUnitToolStripMenuItem.Text = "Ед. измерения";
            // 
            // DictProviderToolStripMenuItem
            // 
            this.DictProviderToolStripMenuItem.Name = "DictProviderToolStripMenuItem";
            this.DictProviderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DictProviderToolStripMenuItem.Text = "Поставщики";
            // 
            // DictWarehousesToolStripMenuItem
            // 
            this.DictWarehousesToolStripMenuItem.Name = "DictWarehousesToolStripMenuItem";
            this.DictWarehousesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DictWarehousesToolStripMenuItem.Text = "Склады";
            // 
            // AccountingToolStripMenuItem
            // 
            this.AccountingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountingReceiptOrderToolStripMenuItem});
            this.AccountingToolStripMenuItem.Name = "AccountingToolStripMenuItem";
            this.AccountingToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.AccountingToolStripMenuItem.Text = "Учет";
            // 
            // AccountingReceiptOrderToolStripMenuItem
            // 
            this.AccountingReceiptOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountingReceiptOrderListToolStripMenuItem,
            this.AccountingReceiptOrderAddToolStripMenuItem});
            this.AccountingReceiptOrderToolStripMenuItem.Name = "AccountingReceiptOrderToolStripMenuItem";
            this.AccountingReceiptOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AccountingReceiptOrderToolStripMenuItem.Text = "Приходной ордер";
            // 
            // AccountingReceiptOrderListToolStripMenuItem
            // 
            this.AccountingReceiptOrderListToolStripMenuItem.Name = "AccountingReceiptOrderListToolStripMenuItem";
            this.AccountingReceiptOrderListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AccountingReceiptOrderListToolStripMenuItem.Text = "Список";
            // 
            // AccountingReceiptOrderAddToolStripMenuItem
            // 
            this.AccountingReceiptOrderAddToolStripMenuItem.Name = "AccountingReceiptOrderAddToolStripMenuItem";
            this.AccountingReceiptOrderAddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AccountingReceiptOrderAddToolStripMenuItem.Text = "Добавление";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 33);
            this.button2.TabIndex = 36;
            this.button2.Text = "Анализ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(701, 230);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(202, 33);
            this.btn_view.TabIndex = 37;
            this.btn_view.Text = "Просмотр";
            this.btn_view.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(113, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(363, 21);
            this.comboBox2.TabIndex = 36;
            // 
            // FormContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 515);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormContracts";
            this.Text = "Модуль договоров";
            this.Load += new System.EventHandler(this.FormContracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContractCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContractSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DictToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DictResourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DictUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DictProviderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DictWarehousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountingReceiptOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountingReceiptOrderListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountingReceiptOrderAddToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConclusionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProviderAgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Underdelivery;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}