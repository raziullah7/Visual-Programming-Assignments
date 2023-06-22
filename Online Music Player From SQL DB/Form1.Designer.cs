namespace Online_Music_Player_From_SQL_DB
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
            this.delete_album_btn = new System.Windows.Forms.Button();
            this.update_album_btn = new System.Windows.Forms.Button();
            this.play_track_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tracks_excel_report = new System.Windows.Forms.Button();
            this.albums_excel_report = new System.Windows.Forms.Button();
            this.albums_word_report = new System.Windows.Forms.Button();
            this.albums_pdf_report = new System.Windows.Forms.Button();
            this.tracks_word_report = new System.Windows.Forms.Button();
            this.tracks_pdf_report = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(931, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.delete_album_btn);
            this.tabPage1.Controls.Add(this.update_album_btn);
            this.tabPage1.Controls.Add(this.play_track_btn);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(923, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Albums";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // delete_album_btn
            // 
            this.delete_album_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.delete_album_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.delete_album_btn.Location = new System.Drawing.Point(758, 315);
            this.delete_album_btn.Name = "delete_album_btn";
            this.delete_album_btn.Size = new System.Drawing.Size(150, 39);
            this.delete_album_btn.TabIndex = 15;
            this.delete_album_btn.Text = "Delete Track";
            this.delete_album_btn.UseVisualStyleBackColor = false;
            this.delete_album_btn.Click += new System.EventHandler(this.delete_album_btn_Click);
            // 
            // update_album_btn
            // 
            this.update_album_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.update_album_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.update_album_btn.Location = new System.Drawing.Point(602, 315);
            this.update_album_btn.Name = "update_album_btn";
            this.update_album_btn.Size = new System.Drawing.Size(150, 39);
            this.update_album_btn.TabIndex = 14;
            this.update_album_btn.Text = "Update Track";
            this.update_album_btn.UseVisualStyleBackColor = false;
            this.update_album_btn.Click += new System.EventHandler(this.update_album_btn_Click);
            // 
            // play_track_btn
            // 
            this.play_track_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.play_track_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_track_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.play_track_btn.Location = new System.Drawing.Point(446, 315);
            this.play_track_btn.Name = "play_track_btn";
            this.play_track_btn.Size = new System.Drawing.Size(150, 39);
            this.play_track_btn.TabIndex = 13;
            this.play_track_btn.Text = "▶   Play Track";
            this.play_track_btn.UseVisualStyleBackColor = false;
            this.play_track_btn.Click += new System.EventHandler(this.play_track_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tracks:";
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 299);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(253, 360);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(669, 183);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(922, 250);
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
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(923, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Operations";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Track";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(41, 54);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(120, 55);
            this.add_btn.TabIndex = 10;
            this.add_btn.Text = "Add Album";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // tracks_excel_report
            // 
            this.tracks_excel_report.Location = new System.Drawing.Point(144, 68);
            this.tracks_excel_report.Name = "tracks_excel_report";
            this.tracks_excel_report.Size = new System.Drawing.Size(120, 55);
            this.tracks_excel_report.TabIndex = 12;
            this.tracks_excel_report.Text = "Tracks.XLSX";
            this.tracks_excel_report.UseVisualStyleBackColor = true;
            this.tracks_excel_report.Click += new System.EventHandler(this.tracks_excel_report_Click);
            // 
            // albums_excel_report
            // 
            this.albums_excel_report.Location = new System.Drawing.Point(141, 68);
            this.albums_excel_report.Name = "albums_excel_report";
            this.albums_excel_report.Size = new System.Drawing.Size(120, 55);
            this.albums_excel_report.TabIndex = 13;
            this.albums_excel_report.Text = "Albums.XLSX";
            this.albums_excel_report.UseVisualStyleBackColor = true;
            this.albums_excel_report.Click += new System.EventHandler(this.albums_excel_report_Click);
            // 
            // albums_word_report
            // 
            this.albums_word_report.Location = new System.Drawing.Point(141, 193);
            this.albums_word_report.Name = "albums_word_report";
            this.albums_word_report.Size = new System.Drawing.Size(120, 55);
            this.albums_word_report.TabIndex = 15;
            this.albums_word_report.Text = "Albums.DOCX";
            this.albums_word_report.UseVisualStyleBackColor = true;
            this.albums_word_report.Click += new System.EventHandler(this.albums_word_report_Click);
            // 
            // albums_pdf_report
            // 
            this.albums_pdf_report.Location = new System.Drawing.Point(141, 318);
            this.albums_pdf_report.Name = "albums_pdf_report";
            this.albums_pdf_report.Size = new System.Drawing.Size(120, 55);
            this.albums_pdf_report.TabIndex = 17;
            this.albums_pdf_report.Text = "Albums.PDF";
            this.albums_pdf_report.UseVisualStyleBackColor = true;
            this.albums_pdf_report.Click += new System.EventHandler(this.albums_pdf_report_Click);
            // 
            // tracks_word_report
            // 
            this.tracks_word_report.Location = new System.Drawing.Point(144, 193);
            this.tracks_word_report.Name = "tracks_word_report";
            this.tracks_word_report.Size = new System.Drawing.Size(120, 55);
            this.tracks_word_report.TabIndex = 14;
            this.tracks_word_report.Text = "Tracks.DOCX";
            this.tracks_word_report.UseVisualStyleBackColor = true;
            this.tracks_word_report.Click += new System.EventHandler(this.tracks_word_report_Click);
            // 
            // tracks_pdf_report
            // 
            this.tracks_pdf_report.Location = new System.Drawing.Point(144, 318);
            this.tracks_pdf_report.Name = "tracks_pdf_report";
            this.tracks_pdf_report.Size = new System.Drawing.Size(120, 55);
            this.tracks_pdf_report.TabIndex = 18;
            this.tracks_pdf_report.Text = "Tracks.PDF";
            this.tracks_pdf_report.UseVisualStyleBackColor = true;
            this.tracks_pdf_report.Click += new System.EventHandler(this.tracks_pdf_report_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Location = new System.Drawing.Point(68, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 152);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Album Actions";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(68, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 156);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Track Actions";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tracks_excel_report);
            this.groupBox3.Controls.Add(this.tracks_word_report);
            this.groupBox3.Controls.Add(this.tracks_pdf_report);
            this.groupBox3.Location = new System.Drawing.Point(297, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 447);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tracks Crystal Reports";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.albums_excel_report);
            this.groupBox4.Controls.Add(this.albums_word_report);
            this.groupBox4.Controls.Add(this.albums_pdf_report);
            this.groupBox4.Location = new System.Drawing.Point(613, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 447);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Albums Crystal Reports";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Excel Format :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Word Format :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "PDF Format :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Excel Format :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Word Format :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "PDF Format :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Albums:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 585);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button play_track_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete_album_btn;
        private System.Windows.Forms.Button update_album_btn;
        private System.Windows.Forms.Button tracks_excel_report;
        private System.Windows.Forms.Button albums_excel_report;
        private System.Windows.Forms.Button albums_word_report;
        private System.Windows.Forms.Button albums_pdf_report;
        private System.Windows.Forms.Button tracks_pdf_report;
        private System.Windows.Forms.Button tracks_word_report;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}

