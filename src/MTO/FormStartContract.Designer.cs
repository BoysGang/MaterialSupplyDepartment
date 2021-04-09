
namespace MTO
{
    partial class FormStartContract
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
            this.btn_addContract = new System.Windows.Forms.Button();
            this.btn_viewContracts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addContract
            // 
            this.btn_addContract.Location = new System.Drawing.Point(105, 130);
            this.btn_addContract.Name = "btn_addContract";
            this.btn_addContract.Size = new System.Drawing.Size(241, 39);
            this.btn_addContract.TabIndex = 3;
            this.btn_addContract.Text = "Добавить новый договор";
            this.btn_addContract.UseVisualStyleBackColor = true;
            this.btn_addContract.Click += new System.EventHandler(this.btn_addContract_Click);
            // 
            // btn_viewContracts
            // 
            this.btn_viewContracts.Location = new System.Drawing.Point(105, 75);
            this.btn_viewContracts.Name = "btn_viewContracts";
            this.btn_viewContracts.Size = new System.Drawing.Size(241, 39);
            this.btn_viewContracts.TabIndex = 2;
            this.btn_viewContracts.Text = "Просмотр договоров";
            this.btn_viewContracts.UseVisualStyleBackColor = true;
            this.btn_viewContracts.Click += new System.EventHandler(this.btn_viewContracts_Click);
            // 
            // FormStartContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.btn_addContract);
            this.Controls.Add(this.btn_viewContracts);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 300);
            this.MinimumSize = new System.Drawing.Size(480, 300);
            this.Name = "FormStartContract";
            this.Text = "Сотрудник бюро договоров";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addContract;
        private System.Windows.Forms.Button btn_viewContracts;
    }
}