
namespace MTO
{
    partial class FormAnalysis
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_analysis = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_header = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_totalUndeliveryCost = new System.Windows.Forms.TextBox();
            this.PK_ContractLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceCipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDatePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDateFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountUnderdelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnderdeliveryPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_analysis)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_analysis, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 564);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_analysis
            // 
            this.dgv_analysis.AllowUserToAddRows = false;
            this.dgv_analysis.AllowUserToDeleteRows = false;
            this.dgv_analysis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_analysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_analysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_ContractLine,
            this.ResourceName,
            this.ResourceCipher,
            this.Unit,
            this.UnitCipher,
            this.DeliveryDatePlan,
            this.DeliveryDateFact,
            this.AmountPlan,
            this.AmountFact,
            this.AmountUnderdelivery,
            this.UnitPrice,
            this.UnderdeliveryPrice});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_analysis.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_analysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_analysis.Location = new System.Drawing.Point(3, 87);
            this.dgv_analysis.Name = "dgv_analysis";
            this.dgv_analysis.ReadOnly = true;
            this.dgv_analysis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_analysis.Size = new System.Drawing.Size(978, 417);
            this.dgv_analysis.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lbl_header, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_export, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(978, 78);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_header.Location = new System.Drawing.Point(278, 29);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(308, 20);
            this.lbl_header.TabIndex = 11;
            this.lbl_header.Text = "Анализ поставок по договору № от";
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(868, 3);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(107, 38);
            this.btn_export.TabIndex = 1;
            this.btn_export.Text = "Экспорт в Excel";
            this.btn_export.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.tb_totalUndeliveryCost);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(781, 510);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 51);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Общая сумма недопоставок:";
            // 
            // tb_totalUndeliveryCost
            // 
            this.tb_totalUndeliveryCost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_totalUndeliveryCost.Location = new System.Drawing.Point(3, 16);
            this.tb_totalUndeliveryCost.Name = "tb_totalUndeliveryCost";
            this.tb_totalUndeliveryCost.ReadOnly = true;
            this.tb_totalUndeliveryCost.Size = new System.Drawing.Size(100, 20);
            this.tb_totalUndeliveryCost.TabIndex = 0;
            // 
            // PK_ContractLine
            // 
            this.PK_ContractLine.HeaderText = "PK_ContractLine";
            this.PK_ContractLine.Name = "PK_ContractLine";
            this.PK_ContractLine.ReadOnly = true;
            this.PK_ContractLine.Visible = false;
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
            // DeliveryDatePlan
            // 
            this.DeliveryDatePlan.HeaderText = "Дата поставки план.";
            this.DeliveryDatePlan.Name = "DeliveryDatePlan";
            this.DeliveryDatePlan.ReadOnly = true;
            // 
            // DeliveryDateFact
            // 
            this.DeliveryDateFact.HeaderText = "Дата поставки факт.";
            this.DeliveryDateFact.Name = "DeliveryDateFact";
            this.DeliveryDateFact.ReadOnly = true;
            // 
            // AmountPlan
            // 
            this.AmountPlan.HeaderText = "Поставка план.";
            this.AmountPlan.Name = "AmountPlan";
            this.AmountPlan.ReadOnly = true;
            // 
            // AmountFact
            // 
            this.AmountFact.HeaderText = "Поставка факт.";
            this.AmountFact.Name = "AmountFact";
            this.AmountFact.ReadOnly = true;
            // 
            // AmountUnderdelivery
            // 
            this.AmountUnderdelivery.HeaderText = "Недопоставка";
            this.AmountUnderdelivery.Name = "AmountUnderdelivery";
            this.AmountUnderdelivery.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Цена за ед., руб.";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // UnderdeliveryPrice
            // 
            this.UnderdeliveryPrice.HeaderText = "Стоимость недопоставки";
            this.UnderdeliveryPrice.Name = "UnderdeliveryPrice";
            this.UnderdeliveryPrice.ReadOnly = true;
            // 
            // FormAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 564);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormAnalysis";
            this.Text = "Анализ выполнения обязательств";
            this.Load += new System.EventHandler(this.FormAnalysis_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_analysis)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_analysis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_totalUndeliveryCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_ContractLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceCipher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCipher;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDatePlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDateFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountUnderdelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnderdeliveryPrice;
    }
}