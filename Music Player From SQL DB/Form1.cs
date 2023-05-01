namespace Music_Player_From_SQL_DB
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();



        public Form1()
        {
            InitializeComponent();
        }

        // load albums button
        private void button1_Click(object sender, EventArgs e)
        {
            //        // trying out mock data first
            //// creating album data access object
            //AlbumsDAO albumsDAO = new AlbumsDAO();
            //// creating 1st mock album object
            //Album a1 = new Album
            //{
            //    ID = 1,
            //    AlbumName = "My First Album",
            //    ArtistName = "Razi",
            //    Year = 2023,
            //    ImageURL = "Nothing yet",
            //    Description = "Nothing special"
            //};
            //// creating 2nd mock album object
            //Album a2 = new Album
            //{
            //    ID = 2,
            //    AlbumName = "My Second Album",
            //    ArtistName = "Razi",
            //    Year = 2023,
            //    ImageURL = "Nothing yet",
            //    Description = "Nothing special"
            //};
            //// adding objects to DAO
            //albumsDAO.albums.Add(a1);
            //albumsDAO.albums.Add(a2);

            // now for the real data
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // creating connection to the grid
            albumBindingSource.DataSource = albumsDAO.getAllAlbums();
            dataGridView1.DataSource = albumBindingSource;
        }

        // search button
        private void button2_Click(object sender, EventArgs e)
        {
            // now for the real data
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // creating connection to the grid
            albumBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);
            dataGridView1.DataSource = albumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // storing the sender of the datagridview to get which
            // specific row and cell gets clicked
            DataGridView dataGridView = (DataGridView) sender;

            // getting row number
            int rowClicked = dataGridView.CurrentRow.Index;
            // MessageBox.Show($"Row # {rowClicked} was clicked!");

            // getting URL's of the respective rows
            string imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();
            // MessageBox.Show(imageURL);

            // loading the thumbnail pic of the clicked row
            pictureBox1.Load(imageURL);
        }
    }
}