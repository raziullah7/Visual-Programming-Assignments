namespace ADO.NET
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            update_btn = new Button();
            submit_btn = new Button();
            delete_btn = new Button();
            display_btn = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(162, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 25);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(162, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(162, 236);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 25);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(108, 112);
            label1.Name = "label1";
            label1.Size = new Size(31, 30);
            label1.TabIndex = 3;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 169);
            label2.Name = "label2";
            label2.Size = new Size(69, 30);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(91, 229);
            label3.Name = "label3";
            label3.Size = new Size(50, 30);
            label3.TabIndex = 5;
            label3.Text = "Age";
            // 
            // update_btn
            // 
            update_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            update_btn.Location = new Point(74, 312);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(96, 45);
            update_btn.TabIndex = 6;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // submit_btn
            // 
            submit_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            submit_btn.Location = new Point(256, 312);
            submit_btn.Name = "submit_btn";
            submit_btn.Size = new Size(96, 45);
            submit_btn.TabIndex = 7;
            submit_btn.Text = "Submit";
            submit_btn.UseVisualStyleBackColor = true;
            submit_btn.Click += submit_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            delete_btn.Location = new Point(74, 390);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(96, 45);
            delete_btn.TabIndex = 8;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // display_btn
            // 
            display_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            display_btn.Location = new Point(256, 390);
            display_btn.Name = "display_btn";
            display_btn.Size = new Size(96, 45);
            display_btn.TabIndex = 9;
            display_btn.Text = "Display";
            display_btn.UseVisualStyleBackColor = true;
            display_btn.Click += display_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(396, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(376, 316);
            dataGridView1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(328, 27);
            label4.Name = "label4";
            label4.Size = new Size(188, 41);
            label4.TabIndex = 11;
            label4.Text = "Information";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(display_btn);
            Controls.Add(delete_btn);
            Controls.Add(submit_btn);
            Controls.Add(update_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button update_btn;
        private Button submit_btn;
        private Button delete_btn;
        private Button display_btn;
        private DataGridView dataGridView1;
        private Label label4;
    }
}