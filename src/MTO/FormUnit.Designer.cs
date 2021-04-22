
namespace MTO
{
    partial class FormUnit
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
            this.dgv_units = new System.Windows.Forms.DataGridView();
            this.ColumnCipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PK_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_resetSearch = new System.Windows.Forms.Button();
            this.tb_cipher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_units)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_units
            // 
            this.dgv_units.AllowUserToAddRows = false;
            this.dgv_units.AllowUserToDeleteRows = false;
            this.dgv_units.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_units.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_units.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCipher,
            this.ColumnName,
            this.PK_Unit});
            this.dgv_units.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_units.Location = new System.Drawing.Point(12, 184);
            this.dgv_units.MultiSelect = false;
            this.dgv_units.Name = "dgv_units";
            this.dgv_units.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_units.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_units.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_units.Size = new System.Drawing.Size(654, 255);
            this.dgv_units.TabIndex = 0;
            this.dgv_units.SelectionChanged += new System.EventHandler(this.dgv_units_SelectionChanged);
            // 
            // ColumnCipher
            // 
            this.ColumnCipher.HeaderText = "Шифр";
            this.ColumnCipher.Name = "ColumnCipher";
            this.ColumnCipher.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Наименование";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // PK_Unit
            // 
            this.PK_Unit.HeaderText = "PK_Unit";
            this.PK_Unit.Name = "PK_Unit";
            this.PK_Unit.ReadOnly = true;
            this.PK_Unit.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Единицы измерения";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_resetSearch);
            this.groupBox1.Controls.Add(this.tb_cipher);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_find);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 109);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btn_resetSearch
            // 
            this.btn_resetSearch.Location = new System.Drawing.Point(565, 78);
            this.btn_resetSearch.Name = "btn_resetSearch";
            this.btn_resetSearch.Size = new System.Drawing.Size(83, 23);
            this.btn_resetSearch.TabIndex = 14;
            this.btn_resetSearch.Text = "Сбросить";
            this.btn_resetSearch.UseVisualStyleBackColor = true;
            this.btn_resetSearch.Click += new System.EventHandler(this.btn_resetSearch_Click);
            // 
            // tb_cipher
            // 
            this.tb_cipher.Location = new System.Drawing.Point(9, 40);
            this.tb_cipher.MaxLength = 50;
            this.tb_cipher.Name = "tb_cipher";
            this.tb_cipher.Size = new System.Drawing.Size(322, 20);
            this.tb_cipher.TabIndex = 8;
            this.tb_cipher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cipher_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Шифр";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(337, 40);
            this.tb_name.MaxLength = 50;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(311, 20);
            this.tb_name.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Наименование";
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(476, 78);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(83, 23);
            this.btn_find.TabIndex = 10;
            this.btn_find.Text = "Найти";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(174, 155);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 20;
            this.btn_change.Text = "Изменить";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(93, 155);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 155);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FormUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_units);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUnit";
            this.Text = "Справочник \"Ед. измерения\"";
            this.Load += new System.EventHandler(this.FormUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_units)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_units;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCipher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_cipher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_Unit;
        private System.Windows.Forms.Button btn_resetSearch;
    }
}