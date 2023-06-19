using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
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
    public partial class AddForm : Form
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

        public AddForm()
        {
            InitializeComponent();
            txt_albumName.Focus();
        }

        // "Add" button
        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                CloudinaryStorage();

                Album album = new Album
                {
                    AlbumName = txt_albumName.Text,
                    ArtistName = txt_artistName.Text,
                    Year = Int32.Parse(txt_year.Text),
                    ImageURL = imageSecureURL,
                    Description = txt_description.Text
                };  

                SqlAlbumsDAO sqlAlbumsDAO = new SqlAlbumsDAO();
                int result = albumsDAO.addOneAlbum(album);
                MessageBox.Show(result + " new row(s) inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Null or empty fields are not allowed!\n" + ex.Message);
                //txt_albumName.Text = string.Empty;
                //txt_artistName.Text = string.Empty;
                //txt_year.Text = string.Empty;
                //txt_description.Text = string.Empty;
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
            // CloudinaryStorage();
        }

        // show "Complete!" when task completed
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // MessageBox.Show("Complete!");
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

        // "Upload" button under the picture box
        private void image_upload_btn_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void txt_albumName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
