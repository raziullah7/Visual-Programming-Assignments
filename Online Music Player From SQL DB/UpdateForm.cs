using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Music_Player_From_SQL_DB
{
    public partial class UpdateForm : Form
    {
        // creating album data access object
        AlbumsDAO albumsDAO = new AlbumsDAO();
        
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            Album album = ExportAlbum.exportAlbum;

            txt_albumName.Text = album.AlbumName;
            txt_artistName.Text = album.ArtistName;
            txt_year.Text = album.Year.ToString();
            album_image.Load(album.ImageURL);
            txt_description.Text = album.Description;
        }
    }
}
