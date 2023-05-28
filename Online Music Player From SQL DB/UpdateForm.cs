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
    public partial class UpdateForm : Form
    {
        // binding source for albums
        BindingSource albumBindingSource = new BindingSource();

        // to reduce DB fetching
        List<Album> albums = new List<Album>();

        // creating album data access object
        AlbumsDAO albumsDAO = new AlbumsDAO();
        


        public UpdateForm()
        {
            InitializeComponent();
            // creating connection to the albums grid
            albums = albumsDAO.getAllAlbums();
            // adding objects to DAO
            albumBindingSource.DataSource = albums;
            dataGridView1.DataSource = albumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // was trying to get the sender via DataGridView object
            // turned out to be pointless
            // DataGridView dataGridView = sender as DataGridView;

            // getting the index of the clicked row
            int clickedRow = dataGridView1.CurrentRow.Index;
            MessageBox.Show($"{clickedRow} # Row Clicked!");
        }


        private void search_Click(object sender, EventArgs e)
        {

        }

    }
}
