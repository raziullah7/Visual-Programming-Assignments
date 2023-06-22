namespace Online_Music_Player_From_SQL_DB
{
    partial class AddTrack
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_track_name = new System.Windows.Forms.TextBox();
            this.txt_track_num = new System.Windows.Forms.TextBox();
            this.txt_video_url = new System.Windows.Forms.TextBox();
            this.txt_lyrics = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.album_id_dropdown = new System.Windows.Forms.ComboBox();
            this.mUSICDataSet = new Online_Music_Player_From_SQL_DB.MUSICDataSet();
            this.mUSICDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mUSICDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUSICDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Track Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Track Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Video URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Album ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lyrics :";
            // 
            // txt_track_name
            // 
            this.txt_track_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_track_name.Location = new System.Drawing.Point(157, 68);
            this.txt_track_name.Name = "txt_track_name";
            this.txt_track_name.Size = new System.Drawing.Size(246, 26);
            this.txt_track_name.TabIndex = 7;
            this.txt_track_name.TextChanged += new System.EventHandler(this.txt_track_name_TextChanged);
            // 
            // txt_track_num
            // 
            this.txt_track_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_track_num.Location = new System.Drawing.Point(157, 116);
            this.txt_track_num.Name = "txt_track_num";
            this.txt_track_num.Size = new System.Drawing.Size(246, 26);
            this.txt_track_num.TabIndex = 8;
            // 
            // txt_video_url
            // 
            this.txt_video_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_video_url.Location = new System.Drawing.Point(157, 164);
            this.txt_video_url.Name = "txt_video_url";
            this.txt_video_url.Size = new System.Drawing.Size(246, 26);
            this.txt_video_url.TabIndex = 9;
            // 
            // txt_lyrics
            // 
            this.txt_lyrics.Location = new System.Drawing.Point(425, 61);
            this.txt_lyrics.Multiline = true;
            this.txt_lyrics.Name = "txt_lyrics";
            this.txt_lyrics.Size = new System.Drawing.Size(363, 215);
            this.txt_lyrics.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(185, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Add A Track";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(425, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // album_id_dropdown
            // 
            this.album_id_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.album_id_dropdown.FormattingEnabled = true;
            this.album_id_dropdown.Location = new System.Drawing.Point(157, 212);
            this.album_id_dropdown.Name = "album_id_dropdown";
            this.album_id_dropdown.Size = new System.Drawing.Size(246, 28);
            this.album_id_dropdown.TabIndex = 13;
            // 
            // mUSICDataSet
            // 
            this.mUSICDataSet.DataSetName = "MUSICDataSet";
            this.mUSICDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mUSICDataSetBindingSource
            // 
            this.mUSICDataSetBindingSource.DataSource = this.mUSICDataSet;
            this.mUSICDataSetBindingSource.Position = 0;
            // 
            // AddTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.album_id_dropdown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_lyrics);
            this.Controls.Add(this.txt_video_url);
            this.Controls.Add(this.txt_track_num);
            this.Controls.Add(this.txt_track_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddTrack";
            this.Text = "AddTrack";
            this.Load += new System.EventHandler(this.AddTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mUSICDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUSICDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_track_name;
        private System.Windows.Forms.TextBox txt_track_num;
        private System.Windows.Forms.TextBox txt_video_url;
        private System.Windows.Forms.TextBox txt_lyrics;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox album_id_dropdown;
        private System.Windows.Forms.BindingSource mUSICDataSetBindingSource;
        private MUSICDataSet mUSICDataSet;
    }
}