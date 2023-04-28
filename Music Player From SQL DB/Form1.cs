namespace Music_Player_From_SQL_DB
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    // trying out mock data first
            // creating album data access object
            AlbumsDAO albumsDAO = new AlbumsDAO();
            // creating 1st mock album object
            Album a1 = new Album
            {
                ID = 1,
                AlbumName = "My First Album",
                ArtistName = "Razi",
                Year = 2023,
                ImageURL = "Nothing yet",
                Description = "Nothing special"
            };
            // creating 2nd mock album object
            Album a2 = new Album
            {
                ID = 2,
                AlbumName = "My Second Album",
                ArtistName = "Razi",
                Year = 2023,
                ImageURL = "Nothing yet",
                Description = "Nothing special"
            };
            // adding objects to DAO
            albumsDAO.albums.Add(a1);
            albumsDAO.albums.Add(a2);

            // creating connection to the grid
            albumBindingSource.DataSource = albumsDAO.albums;
            dataGridView1.DataSource = albumBindingSource;
        }
    }
}