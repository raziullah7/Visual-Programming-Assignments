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

        // "Search Album" button
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
                // making the form
                UpdateForm updateForm = new UpdateForm();
                updateForm.Text = "Updating An Album";
                // passing the album which was clicked
                ExportAlbum.exportAlbum = albums[rowClicked];
                // showing the form
                updateForm.ShowDialog();
            }
        }

        // "Add Album" button
        private void add_btn_Click_1(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Text = "Adding New Album";
            addForm.Show();
        }


        // -------------------------------------------------------------------------- //
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {}
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e) {}


        private void Form1_Load(object sender, EventArgs e) {
            // making the first and second columns of dataGridView1 red and green respectively
            DataGridViewRow row;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                row = dataGridView1.Rows[i];
                row.Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Red };
                row.Cells[1].Style = new DataGridViewCellStyle { BackColor = Color.Green };
            }
        }
    }
}
