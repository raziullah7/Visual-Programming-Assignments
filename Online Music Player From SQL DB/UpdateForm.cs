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
        bool isChooseImageClicked = false;

        //---------------------------------------------------------------------



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
            isChooseImageClicked = true;
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
            CloudinaryStorage();

            // getting passed album
            Album passedAlbum = ExportAlbum.exportAlbum;

            // getting any changes from the textboxes 
            Album album = new Album
            {
                ID = passedAlbum.ID,
                AlbumName = txt_albumName.Text,
                ArtistName = txt_artistName.Text,
                Year = Int32.Parse(txt_year.Text),
                ImageURL = (imageSecureURL == string.Empty)? passedAlbum.ImageURL: imageSecureURL,
                Description = txt_description.Text
            };

            //// this was made initially to not change the values if 
            //// as empty string is passed into the textbox 
            //Album album = new Album
            //{
            //    AlbumName = txt_albumName.Text == string.Empty ? passedAlbum.AlbumName : txt_albumName.Text,
            //    ArtistName = txt_artistName.Text == string.Empty ? passedAlbum.ArtistName : txt_artistName.Text,
            //    Year = txt_year.Text == string.Empty ? passedAlbum.Year : Int32.Parse(txt_year.Text),
            //    ImageURL = imageSecureURL == string.Empty ? passedAlbum.ImageURL : imageSecureURL,
            //    Description = txt_description.Text == string.Empty ? passedAlbum.Description : txt_description.Text
            //};

            try
            {
                // creating album data access object
                AlbumsDAO albumsDAO = new AlbumsDAO();

                // update the album
                int result = albumsDAO.updateOneAlbum(album);

                // print the number of updated rows
                MessageBox.Show(result + " row(s) updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An internal error occured.\nPlease try again after a few minutes.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        // for accessing the Cloudinary cloud account
        private string CloudinaryStorage()
        {
            // making account to look up against
            Account account = new Account(CLOUD_NAME, API_KEY, API_SECRET);
            // assigning the global scope cloudinary object
            cloudinary = new Cloudinary(account);
            if (isChooseImageClicked)
            {
                // uploading the image using the path
                UploadImage(imagePath);
            }
            else
            {
                imageSecureURL = "";
            }
            return imageSecureURL;
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
            // CloudinaryStorage();
        }

        // show "Complete!" when task completed
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // MessageBox.Show("Complete!");
        }

    }
}
