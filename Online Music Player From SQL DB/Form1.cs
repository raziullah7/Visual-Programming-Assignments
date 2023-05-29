using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudinaryDotNet.Actions;
using CloudinaryDotNet;

namespace Online_Music_Player_From_SQL_DB
{
    public partial class Form1 : Form
    {
        // binding source for albums
        BindingSource albumBindingSource = new BindingSource();
        // binding source for tracks
        BindingSource tracksBindingSource = new BindingSource();
        // to reduce DB fetching
        List<Album> albums = new List<Album>();


        //---------------------------------------------------------------------
                        /*SENSITIVE INFORMATION*/
        // setting up Cloudinary
        public Cloudinary cloudinary;
        public const string CLOUD_NAME = "dst7nfsyw";
        public const string API_KEY = "238557421262677";
        public const string API_SECRET = "Isf4qbBrGLs8fcBIMlDKEHr3tUI";
        string imagePath;
        //---------------------------------------------------------------------


        public Form1()
        {
            InitializeComponent();
            // getTheme();

            // adding delete button in every row of albums grid
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            {
                delete.Name = "delete";
                delete.HeaderText = "Delete";
                delete.Text = "Delete";
                delete.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(delete);
            }
            // adding update button in every row of albums grid
            DataGridViewButtonColumn update = new DataGridViewButtonColumn();
            {
                update.Name = "update";
                update.HeaderText = "Update";
                update.Text = "Update";
                update.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(update);
            }

            // creating album data access object
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // creating connection to the albums grid
            albums = albumsDAO.getAllAlbums();
            // adding objects to DAO
            albumBindingSource.DataSource = albums;
            dataGridView1.DataSource = albumBindingSource;

            // changes the width of each column to fit the content
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // loading the tracks of the 
            dataGridView2.DataSource = albums[0].Tracks;

            // loading the image of the first album by default
            pictureBox1.Load(albums[0].ImageURL);
        }

        // "Search" button
        private void button2_Click_1(object sender, EventArgs e)
        {
            // creating album data access object
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // creating connection to the grid
            // filtering and adding objects to DAO
            albumBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);
            dataGridView1.DataSource = albumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // storing the sender of the datagridview to get which
            // specific row and cell gets clicked
            DataGridView dataGridView = sender as DataGridView;
            //DataGridView dataGridView = (DataGridView)sender;

            // getting row number
            int rowClicked = dataGridView.CurrentRow.Index;
            int cellColumnNumber = dataGridView.CurrentCell.ColumnIndex;

            // getting URL's of the respective rows
            string imageURL = dataGridView.Rows[rowClicked].Cells[6].Value.ToString();
            // MessageBox.Show(imageURL);

            // loading the thumbnail pic of the clicked row
            pictureBox1.Load(imageURL);

            // creating connection to the tracks grid
            // creating and adding objects to DAO
            // uses ID of Album and also makes a run to the DB
            // AlbumsDAO albumsDAO = new AlbumsDAO();
            // tracksBindingSource.DataSource = albumsDAO.getTracksUsingJoins((int)dataGridView.Rows[rowClicked].Cells[0].Value);

            // getting the tracks for each respective album
            tracksBindingSource.DataSource = albums[rowClicked].Tracks;
            dataGridView2.DataSource = tracksBindingSource;

            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;

            // making the first and second columns red and green respectively
            DataGridViewRow row;
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                row = dataGridView.Rows[i];
                row.Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Red };
                row.Cells[1].Style = new DataGridViewCellStyle { BackColor = Color.Green };
            }
            
            

            // if column number is 0, delete
            if (cellColumnNumber == 0)
            {
                MessageBox.Show($"Are you sure you want to delete the following:" +
                    $"\nAlbumName : {dataGridView.Rows[rowClicked].Cells[3].Value}" +
                    $"\nArtistName : {dataGridView.Rows[rowClicked].Cells[4].Value}");
            }
            // if column number is 1, update
            else if (cellColumnNumber == 1)
            {
                MessageBox.Show($"Are you sure you want to update the following:" +
                    $"\nAlbumName : {dataGridView.Rows[rowClicked].Cells[3].Value}" +
                    $"\nArtistName : {dataGridView.Rows[rowClicked].Cells[4].Value}");
            }
        }

        // Add button in the "Add Album" section of the form
        private void add_btn_Click_1(object sender, EventArgs e)
        {
            Album album = new Album
            {
                AlbumName = txt_albumName.Text,
                ArtistName = txt_artistName.Text,
                Year = Int32.Parse(txt_year.Text),
                ImageURL = txt_imageUrl.Text,
                Description = txt_description.Text
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addOneAlbum(album);
            MessageBox.Show(result + " new row(s) inserted");
        }

        // "Update Album" button
        private void album_update_btn_Click(object sender, EventArgs e)
        {
            // making UpdateForm.cs appear when "Update Album" is clicked
            var UpdateForm = new UpdateForm();
            UpdateForm.Show();
        }




        //----------------------------------------------------------------------------
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
            cloudinary.Upload(uploadParams);
        }

        // button used to select image from the Windows Explorer
        // "Choose Image"
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

        // "Upload" button under the image
        private void image_upload_btn_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }


        //----------------------------------------------------------------------------
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {}

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e) {}

        private void album_update_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void album_delete_btn_Click(object sender, EventArgs e)
        {

        }    
    }
}
