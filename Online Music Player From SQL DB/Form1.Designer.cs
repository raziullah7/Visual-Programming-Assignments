﻿namespace Online_Music_Player_From_SQL_DB
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.txt_artistName = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_imageUrl = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_albumName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.album_delete_btn = new System.Windows.Forms.Button();
            this.album_update_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1074, 675);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1066, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Albums";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(425, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 31);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(264, 358);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(794, 195);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1050, 250);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(718, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Search Album";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1066, 642);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CRUD Operations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Controls.Add(this.txt_artistName);
            this.groupBox1.Controls.Add(this.txt_description);
            this.groupBox1.Controls.Add(this.txt_imageUrl);
            this.groupBox1.Controls.Add(this.txt_year);
            this.groupBox1.Controls.Add(this.txt_albumName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Album";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(60, 227);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(100, 38);
            this.add_btn.TabIndex = 10;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // txt_artistName
            // 
            this.txt_artistName.Location = new System.Drawing.Point(132, 73);
            this.txt_artistName.Name = "txt_artistName";
            this.txt_artistName.Size = new System.Drawing.Size(209, 26);
            this.txt_artistName.TabIndex = 9;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(132, 175);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(209, 26);
            this.txt_description.TabIndex = 8;
            // 
            // txt_imageUrl
            // 
            this.txt_imageUrl.Location = new System.Drawing.Point(132, 139);
            this.txt_imageUrl.Name = "txt_imageUrl";
            this.txt_imageUrl.Size = new System.Drawing.Size(209, 26);
            this.txt_imageUrl.TabIndex = 7;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(132, 108);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(209, 26);
            this.txt_year.TabIndex = 6;
            // 
            // txt_albumName
            // 
            this.txt_albumName.Location = new System.Drawing.Point(132, 36);
            this.txt_albumName.Name = "txt_albumName";
            this.txt_albumName.Size = new System.Drawing.Size(209, 26);
            this.txt_albumName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Image URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publish Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artist Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.album_delete_btn);
            this.groupBox2.Controls.Add(this.album_update_btn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(462, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 250);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Album Actions";
            // 
            // album_delete_btn
            // 
            this.album_delete_btn.Location = new System.Drawing.Point(15, 117);
            this.album_delete_btn.Name = "album_delete_btn";
            this.album_delete_btn.Size = new System.Drawing.Size(120, 60);
            this.album_delete_btn.TabIndex = 13;
            this.album_delete_btn.Text = "Delete Album";
            this.album_delete_btn.UseVisualStyleBackColor = true;
            // 
            // album_update_btn
            // 
            this.album_update_btn.Location = new System.Drawing.Point(15, 38);
            this.album_update_btn.Name = "album_update_btn";
            this.album_update_btn.Size = new System.Drawing.Size(120, 60);
            this.album_update_btn.TabIndex = 12;
            this.album_update_btn.Text = "Update Album";
            this.album_update_btn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tracks:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 676);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox txt_artistName;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_imageUrl;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_albumName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button album_delete_btn;
        private System.Windows.Forms.Button album_update_btn;
    }
}
