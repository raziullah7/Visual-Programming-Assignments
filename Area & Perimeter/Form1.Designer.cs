namespace Area___Perimeter
{
    partial class main_form
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
            triangle_btn = new Button();
            rectangle_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // triangle_btn
            // 
            triangle_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            triangle_btn.Location = new Point(76, 116);
            triangle_btn.Name = "triangle_btn";
            triangle_btn.Size = new Size(153, 60);
            triangle_btn.TabIndex = 0;
            triangle_btn.Text = "Triangle";
            triangle_btn.UseVisualStyleBackColor = true;
            triangle_btn.Click += button1_Click;
            // 
            // rectangle_btn
            // 
            rectangle_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rectangle_btn.Location = new Point(279, 116);
            rectangle_btn.Name = "rectangle_btn";
            rectangle_btn.Size = new Size(152, 60);
            rectangle_btn.TabIndex = 1;
            rectangle_btn.Text = "Rectangle";
            rectangle_btn.UseVisualStyleBackColor = true;
            rectangle_btn.Click += rectangle_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(166, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 2;
            label1.Text = "Area Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(76, 66);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 3;
            label2.Text = "Select a shape to find area :";
            // 
            // main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 225);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rectangle_btn);
            Controls.Add(triangle_btn);
            Name = "main_form";
            Text = "Shape Selection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button triangle_btn;
        private Button rectangle_btn;
        private Label label1;
        private Label label2;
    }
}