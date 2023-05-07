using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.Windows.Forms;

namespace Music_Player_From_SQL_DB
{
    public partial class Form1 : Form
    {
        // binding source for albums
        BindingSource albumBindingSource = new BindingSource();
        // binding source for tracks
        BindingSource tracksBindingSource = new BindingSource();


        public Form1()
        {
            InitializeComponent();
        }

        // load albums button
        private void button1_Click(object sender, EventArgs e)
        {
            // creating album data access object
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // creating connection to the albums grid
            // adding objects to DAO
            albumBindingSource.DataSource = albumsDAO.getAllAlbums();
            dataGridView1.DataSource = albumBindingSource;
        }

        // search button
        private void button2_Click(object sender, EventArgs e)
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
            DataGridView dataGridView = (DataGridView)sender;

            // getting row number
            int rowClicked = dataGridView.CurrentRow.Index;
            // MessageBox.Show($"Row # {rowClicked} was clicked!");

            // getting URL's of the respective rows
            string imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();
            // MessageBox.Show(imageURL);

            // loading the thumbnail pic of the clicked row
            pictureBox1.Load(imageURL);

            // creating connection to the tracks grid
            // creating and adding objects to DAO
            AlbumsDAO albumsDAO = new AlbumsDAO();
            tracksBindingSource.DataSource = albumsDAO.getTracksUsingJoins((int)dataGridView.Rows[rowClicked].Cells[0].Value);
            dataGridView2.DataSource = tracksBindingSource;
        }

        // Add button in the "Add New Album" section of the form
        private void add_btn_Click(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}