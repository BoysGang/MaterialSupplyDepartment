
namespace MTO
{
    partial class FormReceiptOrderAdd
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
            this.btn_cancelAdd = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_addNClose = new System.Windows.Forms.Button();
            this.tb_receiptOrderNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_delivaryDate = new System.Windows.Forms.DateTimePicker();
            this.cb_warehouseCipher = new System.Windows.Forms.ComboBox();
            this.cb_provider = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_orderLines = new System.Windows.Forms.DataGridView();
            this.cb_contractNumber = new System.Windows.Forms.ComboBox();
            this.PK_ReceiptOrderLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resource = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ResourceCipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnitCipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_deleteLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderLines)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelAdd
            // 
            this.btn_cancelAdd.Location = new System.Drawing.Point(241, 48);
            this.btn_cancelAdd.Name = "btn_cancelAdd";
            this.btn_cancelAdd.Size = new System.Drawing.Size(92, 23);
            this.btn_cancelAdd.TabIndex = 96;
            this.btn_cancelAdd.Text = "Отменить";
            this.btn_cancelAdd.UseVisualStyleBackColor = true;
            this.btn_cancelAdd.Click += new System.EventHandler(this.btn_cancelAdd_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(143, 48);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(92, 23);
            this.btn_add.TabIndex = 95;
            this.btn_add.Text = "Записать";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_addNClose
            // 
            this.btn_addNClose.Location = new System.Drawing.Point(12, 48);
            this.btn_addNClose.Name = "btn_addNClose";
            this.btn_addNClose.Size = new System.Drawing.Size(125, 23);
            this.btn_addNClose.TabIndex = 94;
            this.btn_addNClose.Text = "Записать и закрыть";
            this.btn_addNClose.UseVisualStyleBackColor = true;
            this.btn_addNClose.Click += new System.EventHandler(this.btn_addNClose_Click);
            // 
            // tb_receiptOrderNumber
            // 
            this.tb_receiptOrderNumber.Location = new System.Drawing.Point(360, 12);
            this.tb_receiptOrderNumber.Name = "tb_receiptOrderNumber";
            this.tb_receiptOrderNumber.Size = new System.Drawing.Size(147, 20);
            this.tb_receiptOrderNumber.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(170, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 92;
            this.label1.Text = "Приходный ордер №";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Дата поставки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Поставщик";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 101;
            this.label5.Text = "Шифр склада";
            // 
            // dtp_delivaryDate
            // 
            this.dtp_delivaryDate.Location = new System.Drawing.Point(130, 101);
            this.dtp_delivaryDate.Name = "dtp_delivaryDate";
            this.dtp_delivaryDate.Size = new System.Drawing.Size(147, 20);
            this.dtp_delivaryDate.TabIndex = 102;
            // 
            // cb_warehouseCipher
            // 
            this.cb_warehouseCipher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_warehouseCipher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_warehouseCipher.FormattingEnabled = true;
            this.cb_warehouseCipher.Location = new System.Drawing.Point(130, 151);
            this.cb_warehouseCipher.Name = "cb_warehouseCipher";
            this.cb_warehouseCipher.Size = new System.Drawing.Size(147, 21);
            this.cb_warehouseCipher.TabIndex = 103;
            // 
            // cb_provider
            // 
            this.cb_provider.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_provider.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_provider.FormattingEnabled = true;
            this.cb_provider.Location = new System.Drawing.Point(460, 100);
            this.cb_provider.Name = "cb_provider";
            this.cb_provider.Size = new System.Drawing.Size(147, 21);
            this.cb_provider.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 105;
            this.label6.Text = "Номер договора";
            // 
            // dgv_orderLines
            // 
            this.dgv_orderLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_orderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_ReceiptOrderLine,
            this.Resource,
            this.ResourceCipher,
            this.Unit,
            this.UnitCipher,
            this.AcceptedAmount,
            this.DocumentAmount});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orderLines.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_orderLines.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_orderLines.Location = new System.Drawing.Point(12, 226);
            this.dgv_orderLines.MultiSelect = false;
            this.dgv_orderLines.Name = "dgv_orderLines";
            this.dgv_orderLines.Size = new System.Drawing.Size(639, 185);
            this.dgv_orderLines.TabIndex = 107;
            this.dgv_orderLines.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orderLines_CellEndEdit);
            this.dgv_orderLines.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orderLines_CellValueChanged);
            this.dgv_orderLines.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_orderLines_CurrentCellDirtyStateChanged);
            this.dgv_orderLines.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_orderLines_EditingControlShowing);
            // 
            // cb_contractNumber
            // 
            this.cb_contractNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_contractNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_contractNumber.FormattingEnabled = true;
            this.cb_contractNumber.Location = new System.Drawing.Point(460, 151);
            this.cb_contractNumber.Name = "cb_contractNumber";
            this.cb_contractNumber.Size = new System.Drawing.Size(147, 21);
            this.cb_contractNumber.TabIndex = 108;
            // 
            // PK_ReceiptOrderLine
            // 
            this.PK_ReceiptOrderLine.HeaderText = "PK";
            this.PK_ReceiptOrderLine.Name = "PK_ReceiptOrderLine";
            this.PK_ReceiptOrderLine.Visible = false;
            // 
            // Resource
            // 
            this.Resource.HeaderText = "Ресурс";
            this.Resource.Name = "Resource";
            this.Resource.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Resource.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ResourceCipher
            // 
            this.ResourceCipher.HeaderText = "Шифр ресурса";
            this.ResourceCipher.Name = "ResourceCipher";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Ед. измерения";
            this.Unit.Name = "Unit";
            this.Unit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UnitCipher
            // 
            this.UnitCipher.HeaderText = "Шифр ед. измерения";
            this.UnitCipher.Name = "UnitCipher";
            // 
            // AcceptedAmount
            // 
            this.AcceptedAmount.HeaderText = "Кол-во принято";
            this.AcceptedAmount.Name = "AcceptedAmount";
            // 
            // DocumentAmount
            // 
            this.DocumentAmount.HeaderText = "Кол-во по документу";
            this.DocumentAmount.Name = "DocumentAmount";
            // 
            // btn_deleteLine
            // 
            this.btn_deleteLine.Location = new System.Drawing.Point(12, 197);
            this.btn_deleteLine.Name = "btn_deleteLine";
            this.btn_deleteLine.Size = new System.Drawing.Size(125, 23);
            this.btn_deleteLine.TabIndex = 109;
            this.btn_deleteLine.Text = "Удалить строку";
            this.btn_deleteLine.UseVisualStyleBackColor = true;
            this.btn_deleteLine.Click += new System.EventHandler(this.btn_deleteLine_Click);
            // 
            // FormReceiptOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 421);
            this.Controls.Add(this.btn_deleteLine);
            this.Controls.Add(this.cb_contractNumber);
            this.Controls.Add(this.dgv_orderLines);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_provider);
            this.Controls.Add(this.cb_warehouseCipher);
            this.Controls.Add(this.dtp_delivaryDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancelAdd);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_addNClose);
            this.Controls.Add(this.tb_receiptOrderNumber);
            this.Controls.Add(this.label1);
            this.Name = "FormReceiptOrderAdd";
            this.Text = "Добавление приходного ордера";
            this.Load += new System.EventHandler(this.FormReceiptOrderAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelAdd;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_addNClose;
        private System.Windows.Forms.TextBox tb_receiptOrderNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_delivaryDate;
        private System.Windows.Forms.ComboBox cb_warehouseCipher;
        private System.Windows.Forms.ComboBox cb_provider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_orderLines;
        private System.Windows.Forms.ComboBox cb_contractNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_ReceiptOrderLine;
        private System.Windows.Forms.DataGridViewComboBoxColumn Resource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceCipher;
        private System.Windows.Forms.DataGridViewComboBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCipher;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcceptedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentAmount;
        private System.Windows.Forms.Button btn_deleteLine;
    }
}