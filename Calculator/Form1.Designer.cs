namespace Calculator__Assignment1_
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            AddBtn = new Button();
            SubBtn = new Button();
            MulBtn = new Button();
            DivBtn = new Button();
            ResultBtn = new Button();
            binary_btn = new Button();
            octal_btn = new Button();
            hexa_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(37, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 33);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(37, 325);
            button1.Name = "button1";
            button1.Size = new Size(63, 70);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(98, 325);
            button2.Name = "button2";
            button2.Size = new Size(63, 70);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(158, 325);
            button3.Name = "button3";
            button3.Size = new Size(63, 70);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(37, 257);
            button4.Name = "button4";
            button4.Size = new Size(63, 70);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(98, 257);
            button5.Name = "button5";
            button5.Size = new Size(63, 70);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(158, 257);
            button6.Name = "button6";
            button6.Size = new Size(63, 70);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(37, 186);
            button7.Name = "button7";
            button7.Size = new Size(63, 74);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(98, 186);
            button8.Name = "button8";
            button8.Size = new Size(63, 74);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(158, 186);
            button9.Name = "button9";
            button9.Size = new Size(63, 74);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button0.Location = new Point(37, 393);
            button0.Name = "button0";
            button0.Size = new Size(63, 67);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.Location = new Point(227, 186);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(63, 74);
            AddBtn.TabIndex = 12;
            AddBtn.Text = "+";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // SubBtn
            // 
            SubBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SubBtn.Location = new Point(227, 257);
            SubBtn.Name = "SubBtn";
            SubBtn.Size = new Size(63, 70);
            SubBtn.TabIndex = 13;
            SubBtn.Text = "-";
            SubBtn.UseVisualStyleBackColor = true;
            SubBtn.Click += SubBtn_Click;
            // 
            // MulBtn
            // 
            MulBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MulBtn.Location = new Point(227, 325);
            MulBtn.Name = "MulBtn";
            MulBtn.Size = new Size(63, 70);
            MulBtn.TabIndex = 14;
            MulBtn.Text = "*";
            MulBtn.UseVisualStyleBackColor = true;
            MulBtn.Click += MulBtn_Click;
            // 
            // DivBtn
            // 
            DivBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DivBtn.Location = new Point(227, 393);
            DivBtn.Name = "DivBtn";
            DivBtn.Size = new Size(63, 67);
            DivBtn.TabIndex = 15;
            DivBtn.Text = "/";
            DivBtn.UseVisualStyleBackColor = true;
            DivBtn.Click += DivBtn_Click;
            // 
            // ResultBtn
            // 
            ResultBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResultBtn.Location = new Point(98, 393);
            ResultBtn.Name = "ResultBtn";
            ResultBtn.Size = new Size(123, 67);
            ResultBtn.TabIndex = 16;
            ResultBtn.Text = "Calculate";
            ResultBtn.UseVisualStyleBackColor = true;
            ResultBtn.Click += ResultBtn_Click;
            // 
            // binary_btn
            // 
            binary_btn.Location = new Point(37, 106);
            binary_btn.Name = "binary_btn";
            binary_btn.Size = new Size(85, 74);
            binary_btn.TabIndex = 17;
            binary_btn.Text = "Binary";
            binary_btn.UseVisualStyleBackColor = true;
            // 
            // octal_btn
            // 
            octal_btn.Location = new Point(119, 106);
            octal_btn.Name = "octal_btn";
            octal_btn.Size = new Size(85, 74);
            octal_btn.TabIndex = 18;
            octal_btn.Text = "Octal";
            octal_btn.UseVisualStyleBackColor = true;
            // 
            // hexa_btn
            // 
            hexa_btn.Location = new Point(202, 106);
            hexa_btn.Name = "hexa_btn";
            hexa_btn.Size = new Size(88, 74);
            hexa_btn.TabIndex = 19;
            hexa_btn.Text = "HexaDeci";
            hexa_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(326, 493);
            Controls.Add(hexa_btn);
            Controls.Add(octal_btn);
            Controls.Add(binary_btn);
            Controls.Add(ResultBtn);
            Controls.Add(DivBtn);
            Controls.Add(MulBtn);
            Controls.Add(SubBtn);
            Controls.Add(AddBtn);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button AddBtn;
        private Button SubBtn;
        private Button MulBtn;
        private Button DivBtn;
        private Button ResultBtn;
        private Button binary_btn;
        private Button octal_btn;
        private Button hexa_btn;
    }
}