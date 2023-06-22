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
    public partial class UpdateTrack : Form
    {
        SqlAlbumsDAO sqlAlbumsDAO = new SqlAlbumsDAO();
        List<Album> albums = new List<Album>();

        public UpdateTrack()
        {
            InitializeComponent();
            albums = sqlAlbumsDAO.getAllAlbums();

            foreach (Album album in albums)
            {
                album_id_dropdown.Items.Add(album.ID + ". " + album.AlbumName);
            }
        }

        private void UpdateTrack_Load(object sender, EventArgs e)
        {
            Track track = ExportAlbum.selectedTrack;

            txt_track_name.Text = track.TrackName;
            txt_track_num.Text = track.TrackNumber.ToString();
            txt_video_url.Text = track.VideoURL;
            txt_lyrics.Text = track.TrackLyrics;
            album_id_dropdown.Text = Convert.ToString(track.AlbumID + 1) + ". " + albums[track.AlbumID].AlbumName;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] words = album_id_dropdown.Text.Split('.');
                Track track = new Track
                {
                    TrackID = ExportAlbum.selectedTrack.TrackID,
                    TrackName = txt_track_name.Text,
                    TrackNumber = Convert.ToInt32(txt_track_num.Text),
                    VideoURL = txt_video_url.Text,
                    TrackLyrics = txt_lyrics.Text,
                    AlbumID = Convert.ToInt32(words[0]),
                };

                // update the album
                int result = sqlAlbumsDAO.updateOneTrack(track);

                // print the number of updated rows
                MessageBox.Show(result + " row(s) updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An internal error occured.\nPlease try again after a few minutes.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
