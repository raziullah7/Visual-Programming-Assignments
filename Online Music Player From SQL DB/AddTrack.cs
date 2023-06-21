using MySqlX.XDevAPI.Common;
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
    public partial class AddTrack : Form
    {
        SqlAlbumsDAO sqlAlbumsDAO = new SqlAlbumsDAO();
        List<Album> albums = new List<Album>();
        

        public AddTrack()
        {
            InitializeComponent();

            albums = sqlAlbumsDAO.getAllAlbums();

            foreach (Album album in albums)
            {
                album_id_dropdown.Items.Add(album.ID + ". " + album.AlbumName);
            }
        }

        private void AddTrack_Load(object sender, EventArgs e)
        {

        }

        private void txt_track_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] words = album_id_dropdown.Text.Split('.'); 
            Track track = new Track
            {
                TrackName = txt_track_name.Text,
                TrackNumber = Convert.ToInt32(txt_track_num.Text),
                VideoURL = txt_video_url.Text,
                TrackLyrics = txt_lyrics.Text,
                AlbumID = Convert.ToInt32(words[0]),
            };
            MessageBox.Show($"Album's ID : {track.AlbumID}");
            int newTracks = sqlAlbumsDAO.addOneTrack(track);
            MessageBox.Show($"  {newTracks} new track(s) added! ");
        }
    }
}
