
namespace MTO
{
    partial class FormProviders
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
            this.dgv_providers = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnINN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheckingAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCorrespondentAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PK_Provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_BIK = new System.Windows.Forms.TextBox();
            this.tb_phoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_correspondentAccount = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_INN = new System.Windows.Forms.TextBox();
            this.tb_checkingAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_providers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_providers
            // 
            this.dgv_providers.AllowUserToAddRows = false;
            this.dgv_providers.AllowUserToDeleteRows = false;
            this.dgv_providers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_providers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_providers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnINN,
            this.ColumnAddress,
            this.ColumnPhoneNumber,
            this.ColumnCheckingAccount,
            this.ColumnCorrespondentAccount,
            this.ColumnBIK,
            this.PK_Provider});
            this.dgv_providers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_providers.Location = new System.Drawing.Point(12, 280);
            this.dgv_providers.MultiSelect = false;
            this.dgv_providers.Name = "dgv_providers";
            this.dgv_providers.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_providers.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_providers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_providers.Size = new System.Drawing.Size(665, 247);
            this.dgv_providers.TabIndex = 4;
            this.dgv_providers.SelectionChanged += new System.EventHandler(this.dgv_providers_SelectionChanged);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Наименование";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnINN
            // 
            this.ColumnINN.HeaderText = "ИНН";
            this.ColumnINN.Name = "ColumnINN";
            this.ColumnINN.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Адрес";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            // 
            // ColumnPhoneNumber
            // 
            this.ColumnPhoneNumber.HeaderText = "Номер телефона";
            this.ColumnPhoneNumber.Name = "ColumnPhoneNumber";
            this.ColumnPhoneNumber.ReadOnly = true;
            // 
            // ColumnCheckingAccount
            // 
            this.ColumnCheckingAccount.HeaderText = "Расчетный счет";
            this.ColumnCheckingAccount.Name = "ColumnCheckingAccount";
            this.ColumnCheckingAccount.ReadOnly = true;
            // 
            // ColumnCorrespondentAccount
            // 
            this.ColumnCorrespondentAccount.HeaderText = "Корреспондентский счет";
            this.ColumnCorrespondentAccount.Name = "ColumnCorrespondentAccount";
            this.ColumnCorrespondentAccount.ReadOnly = true;
            // 
            // ColumnBIK
            // 
            this.ColumnBIK.HeaderText = "БИК";
            this.ColumnBIK.Name = "ColumnBIK";
            this.ColumnBIK.ReadOnly = true;
            // 
            // PK_Provider
            // 
            this.PK_Provider.HeaderText = "PK_Provider";
            this.PK_Provider.Name = "PK_Provider";
            this.PK_Provider.ReadOnly = true;
            this.PK_Provider.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поставщики";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_BIK);
            this.groupBox1.Controls.Add(this.tb_phoneNumber);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_find);
            this.groupBox1.Controls.Add(this.tb_address);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_correspondentAccount);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_INN);
            this.groupBox1.Controls.Add(this.tb_checkingAccount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 200);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // tb_BIK
            // 
            this.tb_BIK.Location = new System.Drawing.Point(328, 123);
            this.tb_BIK.Name = "tb_BIK";
            this.tb_BIK.Size = new System.Drawing.Size(320, 20);
            this.tb_BIK.TabIndex = 25;
            // 
            // tb_phoneNumber
            // 
            this.tb_phoneNumber.Location = new System.Drawing.Point(9, 123);
            this.tb_phoneNumber.Name = "tb_phoneNumber";
            this.tb_phoneNumber.Size = new System.Drawing.Size(313, 20);
            this.tb_phoneNumber.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "БИК";
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(565, 162);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(83, 22);
            this.btn_find.TabIndex = 10;
            this.btn_find.Text = "Найти";
            this.btn_find.UseVisualStyleBackColor = true;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(9, 81);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(313, 20);
            this.tb_address.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Адрес";
            // 
            // tb_correspondentAccount
            // 
            this.tb_correspondentAccount.Location = new System.Drawing.Point(328, 81);
            this.tb_correspondentAccount.Name = "tb_correspondentAccount";
            this.tb_correspondentAccount.Size = new System.Drawing.Size(320, 20);
            this.tb_correspondentAccount.TabIndex = 23;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(9, 40);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(313, 20);
            this.tb_name.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Корреспондентский счет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ИНН";
            // 
            // tb_INN
            // 
            this.tb_INN.Location = new System.Drawing.Point(9, 164);
            this.tb_INN.Name = "tb_INN";
            this.tb_INN.Size = new System.Drawing.Size(313, 20);
            this.tb_INN.TabIndex = 13;
            // 
            // tb_checkingAccount
            // 
            this.tb_checkingAccount.Location = new System.Drawing.Point(328, 40);
            this.tb_checkingAccount.Name = "tb_checkingAccount";
            this.tb_checkingAccount.Size = new System.Drawing.Size(320, 20);
            this.tb_checkingAccount.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Наименование";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Расчетный счет";
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(174, 251);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 29;
            this.btn_change.Text = "Изменить";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(93, 251);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 251);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 27;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FormProviders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 539);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_providers);
            this.Controls.Add(this.label1);
            this.Name = "FormProviders";
            this.Text = "Справочник \"Поставщики\"";
            this.Activated += new System.EventHandler(this.FormProviders_Activated);
            this.Load += new System.EventHandler(this.FormProviders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_providers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_providers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnINN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCheckingAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCorrespondentAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBIK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_BIK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_correspondentAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_phoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_checkingAccount;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_INN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_Provider;
    }
}