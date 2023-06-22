using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Music_Player_From_SQL_DB
{
    public partial class DeleteTrack : Form
    {
        public DeleteTrack()
        {
            InitializeComponent();
        }

        private void DeleteTrack_Load(object sender, EventArgs e)
        {
            Label label = new Label()
            {
                Text = $"Track Name : {ExportAlbum.selectedTrack.TrackName}\n" +
                $"Track Number : {ExportAlbum.selectedTrack.TrackNumber.ToString()}\n" +
                $"Video URL : {ExportAlbum.selectedTrack.VideoURL}",
                Location = new Point(30, 70),
                AutoSize = true,
                Font = new Font("Calibri", 12),
            };
            this.Controls.Add(label);
        }

        // Delete button
        private void button1_Click(object sender, EventArgs e)
        {
            Track track = ExportAlbum.selectedTrack;
            
            SqlAlbumsDAO sqlAlbumsDAO = new SqlAlbumsDAO();
            int result = sqlAlbumsDAO.deleteOneTrack(track);

            MessageBox.Show($"  {result} row(s) deleted!    ");
            this.Close();
        }

        // Cancel button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
