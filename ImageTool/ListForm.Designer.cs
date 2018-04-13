namespace ImageTool
{
    partial class ListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_page = new System.Windows.Forms.NumericUpDown();
            this.nud_num = new System.Windows.Forms.NumericUpDown();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_page)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_num)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 32F);
            this.label1.Location = new System.Drawing.Point(2, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "去往第";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 32F);
            this.label2.Location = new System.Drawing.Point(243, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "章，第";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 32F);
            this.label3.Location = new System.Drawing.Point(497, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "页";
            // 
            // nud_page
            // 
            this.nud_page.Font = new System.Drawing.Font("宋体", 32F);
            this.nud_page.Location = new System.Drawing.Point(146, 26);
            this.nud_page.Name = "nud_page";
            this.nud_page.Size = new System.Drawing.Size(91, 56);
            this.nud_page.TabIndex = 1;
            this.nud_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nud_num
            // 
            this.nud_num.Font = new System.Drawing.Font("宋体", 32F);
            this.nud_num.Location = new System.Drawing.Point(397, 26);
            this.nud_num.Name = "nud_num";
            this.nud_num.Size = new System.Drawing.Size(94, 56);
            this.nud_num.TabIndex = 1;
            this.nud_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("宋体", 16F);
            this.btn_ok.Location = new System.Drawing.Point(177, 88);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(240, 31);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "确    定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // ListForm
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_ok;
            this.ClientSize = new System.Drawing.Size(587, 123);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.nud_num);
            this.Controls.Add(this.nud_page);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListForm";
            this.Deactivate += new System.EventHandler(this.ListForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nud_page)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_page;
        private System.Windows.Forms.NumericUpDown nud_num;
        private System.Windows.Forms.Button btn_ok;
    }
}