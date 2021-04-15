
namespace MTO
{
    partial class FormProvidersAdd
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
            this.label8 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_phoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.tb_INN = new System.Windows.Forms.MaskedTextBox();
            this.tb_checkingAccount = new System.Windows.Forms.MaskedTextBox();
            this.tb_correspondentAccount = new System.Windows.Forms.MaskedTextBox();
            this.tb_BIK = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "БИК";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(12, 70);
            this.tb_address.MaxLength = 100;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(313, 20);
            this.tb_address.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Адрес";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(12, 29);
            this.tb_name.MaxLength = 50;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(313, 20);
            this.tb_name.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Корреспондентский счет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "ИНН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Наименование";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Расчетный счет";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(250, 318);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 42;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(169, 318);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 41;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_phoneNumber
            // 
            this.tb_phoneNumber.Location = new System.Drawing.Point(12, 112);
            this.tb_phoneNumber.Mask = "+7 (000) 000-00-00";
            this.tb_phoneNumber.Name = "tb_phoneNumber";
            this.tb_phoneNumber.Size = new System.Drawing.Size(313, 20);
            this.tb_phoneNumber.TabIndex = 43;
            // 
            // tb_INN
            // 
            this.tb_INN.Location = new System.Drawing.Point(12, 153);
            this.tb_INN.Mask = "000000000000";
            this.tb_INN.Name = "tb_INN";
            this.tb_INN.Size = new System.Drawing.Size(313, 20);
            this.tb_INN.TabIndex = 44;
            // 
            // tb_checkingAccount
            // 
            this.tb_checkingAccount.Location = new System.Drawing.Point(12, 197);
            this.tb_checkingAccount.Mask = "00000000000000000000";
            this.tb_checkingAccount.Name = "tb_checkingAccount";
            this.tb_checkingAccount.Size = new System.Drawing.Size(313, 20);
            this.tb_checkingAccount.TabIndex = 45;
            // 
            // tb_correspondentAccount
            // 
            this.tb_correspondentAccount.Location = new System.Drawing.Point(12, 238);
            this.tb_correspondentAccount.Mask = "00000000000000000000";
            this.tb_correspondentAccount.Name = "tb_correspondentAccount";
            this.tb_correspondentAccount.Size = new System.Drawing.Size(313, 20);
            this.tb_correspondentAccount.TabIndex = 46;
            // 
            // tb_BIK
            // 
            this.tb_BIK.Location = new System.Drawing.Point(12, 280);
            this.tb_BIK.Mask = "000000000";
            this.tb_BIK.Name = "tb_BIK";
            this.tb_BIK.Size = new System.Drawing.Size(313, 20);
            this.tb_BIK.TabIndex = 47;
            // 
            // FormProvidersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 352);
            this.Controls.Add(this.tb_BIK);
            this.Controls.Add(this.tb_correspondentAccount);
            this.Controls.Add(this.tb_checkingAccount);
            this.Controls.Add(this.tb_INN);
            this.Controls.Add(this.tb_phoneNumber);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Name = "FormProvidersAdd";
            this.Text = "Добавление поставщика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.MaskedTextBox tb_phoneNumber;
        private System.Windows.Forms.MaskedTextBox tb_INN;
        private System.Windows.Forms.MaskedTextBox tb_checkingAccount;
        private System.Windows.Forms.MaskedTextBox tb_correspondentAccount;
        private System.Windows.Forms.MaskedTextBox tb_BIK;
    }
}