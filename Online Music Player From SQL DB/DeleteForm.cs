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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        // pressing "No" will close the Delete Form
        private void no_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // getting the passed album
                Album passedAlbum = ExportAlbum.exportAlbum;

                // making the Data Access Object
                AlbumsDAO albumsDAO = new AlbumsDAO();

                // deleting the clicked album
                int result = albumsDAO.deleteOneAlbum(passedAlbum);

                // print the number of deleted rows
                MessageBox.Show(result + " row(s) deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An internal error occured.\nPlease try again after a few minutes.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteForm_Load(object sender, EventArgs e) { }
    }
}
