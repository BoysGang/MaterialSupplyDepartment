
namespace MTO
{
    partial class FormStartAccounting
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
            this.btn_viewReceiptOrders = new System.Windows.Forms.Button();
            this.btn_addReceiptOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_viewReceiptOrders
            // 
            this.btn_viewReceiptOrders.Location = new System.Drawing.Point(105, 75);
            this.btn_viewReceiptOrders.Name = "btn_viewReceiptOrders";
            this.btn_viewReceiptOrders.Size = new System.Drawing.Size(241, 39);
            this.btn_viewReceiptOrders.TabIndex = 0;
            this.btn_viewReceiptOrders.Text = "Просмотр приходных ордеров";
            this.btn_viewReceiptOrders.UseVisualStyleBackColor = true;
            this.btn_viewReceiptOrders.Click += new System.EventHandler(this.btn_viewReceiptOrders_Click);
            // 
            // btn_addReceiptOrder
            // 
            this.btn_addReceiptOrder.Location = new System.Drawing.Point(105, 130);
            this.btn_addReceiptOrder.Name = "btn_addReceiptOrder";
            this.btn_addReceiptOrder.Size = new System.Drawing.Size(241, 39);
            this.btn_addReceiptOrder.TabIndex = 1;
            this.btn_addReceiptOrder.Text = "Добавить новый приходный ордер";
            this.btn_addReceiptOrder.UseVisualStyleBackColor = true;
            this.btn_addReceiptOrder.Click += new System.EventHandler(this.btn_addReceiptOrder_Click);
            // 
            // FormStartAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.btn_addReceiptOrder);
            this.Controls.Add(this.btn_viewReceiptOrders);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 300);
            this.MinimumSize = new System.Drawing.Size(480, 300);
            this.Name = "FormStartAccounting";
            this.Text = "Сотрудник бюро учета";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_viewReceiptOrders;
        private System.Windows.Forms.Button btn_addReceiptOrder;
    }
}