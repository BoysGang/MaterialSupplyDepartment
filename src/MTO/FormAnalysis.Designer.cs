
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Resource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDatePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDateFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountUnderdelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnderdeliveryPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_header = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tb_totalUndeliveryCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 564);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Resource,
            this.Unit,
            this.DeliveryDatePlan,
            this.DeliveryDateFact,
            this.AmountPlan,
            this.AmountFact,
            this.AmountUnderdelivery,
            this.UnitPrice,
            this.UnderdeliveryPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(818, 417);
            this.dataGridView1.TabIndex = 14;
            // 
            // Resource
            // 
            this.Resource.HeaderText = "Ресурс";
            this.Resource.Name = "Resource";
            this.Resource.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Ед. измерения";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(818, 78);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_header.Location = new System.Drawing.Point(198, 29);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(308, 20);
            this.lbl_header.TabIndex = 11;
            this.lbl_header.Text = "Анализ поставок по договору № от";
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(708, 3);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(621, 510);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 51);
            this.flowLayoutPanel1.TabIndex = 16;
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
            // FormAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 564);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormAnalysis";
            this.Text = "Анализ выполнения обязательств";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDatePlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDateFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountUnderdelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnderdeliveryPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_totalUndeliveryCost;
    }
}