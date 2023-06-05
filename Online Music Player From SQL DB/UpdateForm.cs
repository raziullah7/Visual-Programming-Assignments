using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
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
using System.Collections;

namespace Online_Music_Player_From_SQL_DB
{
    public partial class UpdateForm : Form
    {
        //---------------------------------------------------------------------
        /*SENSITIVE INFORMATION*/
        // setting up Cloudinary
        public Cloudinary cloudinary;
        public const string CLOUD_NAME = "dst7nfsyw";
        public const string API_KEY = "238557421262677";
        public const string API_SECRET = "Isf4qbBrGLs8fcBIMlDKEHr3tUI";
        string imagePath;
        string imageSecureURL;
        //---------------------------------------------------------------------

        // creating album data access object
        AlbumsDAO albumsDAO = new AlbumsDAO();
        
        public UpdateForm()
        {
            InitializeComponent();
        }

        // do these things the moment the form is loaded
        private void UpdateForm_Load(object sender, EventArgs e)
        {
            Album album = ExportAlbum.exportAlbum;

            txt_albumName.Text = album.AlbumName;
            txt_artistName.Text = album.ArtistName;
            txt_year.Text = album.Year.ToString();
            album_image.Load(album.ImageURL);
            txt_description.Text = album.Description;
        }

        // button used to select image from the Windows Explorer
        // "Choose Image" under the picture box
        private void image_choose_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                // making filters for the types of files
                // dialog.Filter = "JPG files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
                dialog.Filter = "Image | *.jpg;*.jpeg;*.png";
                // checking if the OpenFileDialog works
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // assigning the image
                    album_image.Image = new Bitmap(dialog.FileName);
                    // getting the local path to image
                    imagePath = dialog.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occur", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // update btn
        private void update_btn_Click(object sender, EventArgs e)
        {
            
            Album passedAlbum = ExportAlbum.exportAlbum;
            Album album = new Album
            {
                AlbumName = txt_albumName.Text,
                ArtistName = txt_artistName.Text,
                Year = Int32.Parse(txt_year.Text),
                ImageURL = imageSecureURL,
                Description = txt_description.Text
            };

            Album newAlbum = new Album();
            if (!(passedAlbum.AlbumName.Equals(album.AlbumName)))
            {
                newAlbum.AlbumName = album.AlbumName;
            }
            if (!(passedAlbum.ArtistName.Equals(album.ArtistName)))
            {
                newAlbum.ArtistName = album.ArtistName;
            }
            if (passedAlbum.Year == album.Year)
            {
                newAlbum.Year = album.Year;
            }
            if (!(passedAlbum.Description.Equals(album.Description)))
            {
                newAlbum.Description = album.Description;
            }
            if (!(passedAlbum.ArtistName.Equals(album.ArtistName)))
            {

            }

            if (passedAlbum.AlbumName == album.AlbumName && passedAlbum.ArtistName == album.ArtistName && passedAlbum.Year == album.Year && passedAlbum.ImageURL == album.ImageURL && passedAlbum.Description == album.Description)
            {
                MessageBox.Show("0 Albums Updated!");
            }
            else
            {
                //Album newAlbum = new Album
                //{
                //    AlbumName = txt_albumName.Text,
                //    ArtistName = txt_artistName.Text,
                //    Year = Int32.Parse(txt_year.Text),
                //    ImageURL = imageSecureURL,
                //    Description = txt_description.Text
                //};
            }
        }

        // for accessing the Cloudinary cloud account
        private void CloudinaryStorage()
        {
            // making account to look up against
            Account account = new Account(CLOUD_NAME, API_KEY, API_SECRET);
            // assigning the global scope cloudinary object
            cloudinary = new Cloudinary(account);
            // uploading the image using the path
            UploadImage(imagePath);
        }

        // for the actual uploading to Cloudinary
        private void UploadImage(string imagePath)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(imagePath)
            };
            var uploadResult = cloudinary.Upload(uploadParams);
            imageSecureURL = uploadResult.SecureUrl.ToString();
        }

        // backgroudworker sets up the connection with Cloudinary
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CloudinaryStorage();
        }

        // show "Complete!" when task completed
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Complete!");
        }

    }
}
