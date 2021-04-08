
namespace MTO
{
    partial class FormContractAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_actNumber = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nud_customerPenalty = new System.Windows.Forms.NumericUpDown();
            this.nud_supplierPenalty = new System.Windows.Forms.NumericUpDown();
            this.dtp_expiredDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_customerAgentRole = new System.Windows.Forms.TextBox();
            this.tb_customerAgentName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_providerAgentRole = new System.Windows.Forms.TextBox();
            this.tb_providerAgentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_provider = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_conclusionCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CipherResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CipherUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_conclusionDate = new System.Windows.Forms.DateTimePicker();
            this.btn_AddNClose = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancelAdd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_customerPenalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_supplierPenalty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Договор поставки №";
            // 
            // tb_actNumber
            // 
            this.tb_actNumber.Location = new System.Drawing.Point(303, 11);
            this.tb_actNumber.Name = "tb_actNumber";
            this.tb_actNumber.Size = new System.Drawing.Size(118, 20);
            this.tb_actNumber.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 482);
            this.tabControl1.TabIndex = 75;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtp_startDate);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.dtp_expiredDate);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.cb_provider);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tb_conclusionCity);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(737, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основное";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Location = new System.Drawing.Point(545, 51);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(147, 20);
            this.dtp_startDate.TabIndex = 89;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.nud_customerPenalty);
            this.groupBox3.Controls.Add(this.nud_supplierPenalty);
            this.groupBox3.Location = new System.Drawing.Point(54, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(638, 90);
            this.groupBox3.TabIndex = 88;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ответственность сторон";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(430, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Неустойка, в %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(16, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "Штраф поставщику, в %";
            // 
            // nud_customerPenalty
            // 
            this.nud_customerPenalty.DecimalPlaces = 2;
            this.nud_customerPenalty.Location = new System.Drawing.Point(541, 39);
            this.nud_customerPenalty.Name = "nud_customerPenalty";
            this.nud_customerPenalty.Size = new System.Drawing.Size(69, 20);
            this.nud_customerPenalty.TabIndex = 1;
            // 
            // nud_supplierPenalty
            // 
            this.nud_supplierPenalty.DecimalPlaces = 2;
            this.nud_supplierPenalty.Location = new System.Drawing.Point(149, 39);
            this.nud_supplierPenalty.Name = "nud_supplierPenalty";
            this.nud_supplierPenalty.Size = new System.Drawing.Size(69, 20);
            this.nud_supplierPenalty.TabIndex = 0;
            // 
            // dtp_expiredDate
            // 
            this.dtp_expiredDate.Location = new System.Drawing.Point(545, 101);
            this.dtp_expiredDate.Name = "dtp_expiredDate";
            this.dtp_expiredDate.Size = new System.Drawing.Size(147, 20);
            this.dtp_expiredDate.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(405, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 86;
            this.label9.Text = "Дата истечения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(405, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "Дата начала";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_customerAgentRole);
            this.groupBox2.Controls.Add(this.tb_customerAgentName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(408, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 138);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Представитель заказчика";
            // 
            // tb_customerAgentRole
            // 
            this.tb_customerAgentRole.Location = new System.Drawing.Point(79, 70);
            this.tb_customerAgentRole.Name = "tb_customerAgentRole";
            this.tb_customerAgentRole.Size = new System.Drawing.Size(199, 20);
            this.tb_customerAgentRole.TabIndex = 72;
            // 
            // tb_customerAgentName
            // 
            this.tb_customerAgentName.Location = new System.Drawing.Point(79, 34);
            this.tb_customerAgentName.Name = "tb_customerAgentName";
            this.tb_customerAgentName.Size = new System.Drawing.Size(199, 20);
            this.tb_customerAgentName.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Должность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "ФИО";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_providerAgentRole);
            this.groupBox1.Controls.Add(this.tb_providerAgentName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(54, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 138);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Представитель поставщика";
            // 
            // tb_providerAgentRole
            // 
            this.tb_providerAgentRole.Location = new System.Drawing.Point(79, 70);
            this.tb_providerAgentRole.Name = "tb_providerAgentRole";
            this.tb_providerAgentRole.Size = new System.Drawing.Size(201, 20);
            this.tb_providerAgentRole.TabIndex = 72;
            // 
            // tb_providerAgentName
            // 
            this.tb_providerAgentName.Location = new System.Drawing.Point(79, 34);
            this.tb_providerAgentName.Name = "tb_providerAgentName";
            this.tb_providerAgentName.Size = new System.Drawing.Size(201, 20);
            this.tb_providerAgentName.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "ФИО";
            // 
            // cb_provider
            // 
            this.cb_provider.FormattingEnabled = true;
            this.cb_provider.Location = new System.Drawing.Point(210, 93);
            this.cb_provider.Name = "cb_provider";
            this.cb_provider.Size = new System.Drawing.Size(113, 21);
            this.cb_provider.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(51, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Поставщик";
            // 
            // tb_conclusionCity
            // 
            this.tb_conclusionCity.Location = new System.Drawing.Point(210, 54);
            this.tb_conclusionCity.Name = "tb_conclusionCity";
            this.tb_conclusionCity.Size = new System.Drawing.Size(113, 20);
            this.tb_conclusionCity.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(51, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Место заключения договора";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(737, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спецификация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.CipherResource,
            this.ColumnAmount,
            this.ColumnUnit,
            this.CipherUnit,
            this.ColumnUnitPrice,
            this.ColumnPrice,
            this.ColumnDeliveryDate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Наименование";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CipherResource
            // 
            this.CipherResource.HeaderText = "Шифр ресурса";
            this.CipherResource.Name = "CipherResource";
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.HeaderText = "Кол-во";
            this.ColumnAmount.Name = "ColumnAmount";
            // 
            // ColumnUnit
            // 
            this.ColumnUnit.HeaderText = "Ед. измерения";
            this.ColumnUnit.Name = "ColumnUnit";
            this.ColumnUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CipherUnit
            // 
            this.CipherUnit.HeaderText = "Шифр ед. измерения";
            this.CipherUnit.Name = "CipherUnit";
            // 
            // ColumnUnitPrice
            // 
            this.ColumnUnitPrice.HeaderText = "Цена за единицу, руб.";
            this.ColumnUnitPrice.Name = "ColumnUnitPrice";
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
            // 
            // dtp_conclusionDate
            // 
            this.dtp_conclusionDate.Location = new System.Drawing.Point(481, 12);
            this.dtp_conclusionDate.Name = "dtp_conclusionDate";
            this.dtp_conclusionDate.Size = new System.Drawing.Size(147, 20);
            this.dtp_conclusionDate.TabIndex = 78;
            // 
            // btn_AddNClose
            // 
            this.btn_AddNClose.Location = new System.Drawing.Point(12, 42);
            this.btn_AddNClose.Name = "btn_AddNClose";
            this.btn_AddNClose.Size = new System.Drawing.Size(125, 23);
            this.btn_AddNClose.TabIndex = 89;
            this.btn_AddNClose.Text = "Записать и закрыть";
            this.btn_AddNClose.UseVisualStyleBackColor = true;
            this.btn_AddNClose.Click += new System.EventHandler(this.btn_AddNClose_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(143, 42);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(92, 23);
            this.btn_add.TabIndex = 90;
            this.btn_add.Text = "Записать";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancelAdd
            // 
            this.btn_cancelAdd.Location = new System.Drawing.Point(241, 42);
            this.btn_cancelAdd.Name = "btn_cancelAdd";
            this.btn_cancelAdd.Size = new System.Drawing.Size(92, 23);
            this.btn_cancelAdd.TabIndex = 91;
            this.btn_cancelAdd.Text = "Отменить";
            this.btn_cancelAdd.UseVisualStyleBackColor = true;
            this.btn_cancelAdd.Click += new System.EventHandler(this.btn_cancelAdd_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(435, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 20);
            this.label12.TabIndex = 92;
            this.label12.Text = "от";
            // 
            // FormContractAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 560);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_cancelAdd);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_AddNClose);
            this.Controls.Add(this.tb_actNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dtp_conclusionDate);
            this.Name = "FormContractAdd";
            this.Text = "Добавление договора";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_customerPenalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_supplierPenalty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_actNumber;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nud_customerPenalty;
        private System.Windows.Forms.NumericUpDown nud_supplierPenalty;
        private System.Windows.Forms.DateTimePicker dtp_expiredDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_customerAgentRole;
        private System.Windows.Forms.TextBox tb_customerAgentName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_providerAgentRole;
        private System.Windows.Forms.TextBox tb_providerAgentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_provider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_conclusionCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_conclusionDate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AddNClose;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancelAdd;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CipherResource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CipherUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeliveryDate;
    }
}