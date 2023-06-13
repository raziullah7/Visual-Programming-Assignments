namespace Online_Music_Player_From_SQL_DB
{
    partial class DeleteForm
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
            this.yes_btn = new System.Windows.Forms.Button();
            this.no_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to delete the following?";
            // 
            // yes_btn
            // 
            this.yes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_btn.Location = new System.Drawing.Point(207, 222);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Size = new System.Drawing.Size(90, 33);
            this.yes_btn.TabIndex = 1;
            this.yes_btn.Text = "Yes";
            this.yes_btn.UseVisualStyleBackColor = true;
            this.yes_btn.Click += new System.EventHandler(this.yes_btn_Click);
            // 
            // no_btn
            // 
            this.no_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_btn.Location = new System.Drawing.Point(316, 222);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(90, 33);
            this.no_btn.TabIndex = 2;
            this.no_btn.Text = "No";
            this.no_btn.UseVisualStyleBackColor = true;
            this.no_btn.Click += new System.EventHandler(this.no_btn_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 279);
            this.Controls.Add(this.no_btn);
            this.Controls.Add(this.yes_btn);
            this.Controls.Add(this.label1);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yes_btn;
        private System.Windows.Forms.Button no_btn;
    }
}