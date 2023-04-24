using System.Data;
using System.Data.SqlClient;

namespace ADO.NET
{
    public partial class Form1 : Form
    {
        string conn = "Data Source = DESKTOP-B975C1K\\SQLEXPRESS;" +
            "Initial Catalog = Demo;" +
            "User Id = ;    Password = ;    Integrated Security = true;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void submit_btn_Click(object sender, EventArgs e)
        {
            // creating connection using conn string
            SqlConnection sqlconn = new SqlConnection(conn);
            // writing query
            string query = "Insert into STUDENT (Std_Id, Std_Name, Std_Age) values (@id, @name, @age)";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            // getting parameters from textboxes
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", textBox3.Text);
            // opening connection
            sqlconn.Open();
            // ExecuteNonQuery() returns the number of rows that are
            // affected after the sql query is run
            int report = cmd.ExecuteNonQuery();
            // closing connection
            sqlconn.Close();

            // if the number of affected rows is greater than zero,
            // than it means that Insert process into the DataBase
            // was successful
            if (report > 0)
            {
                MessageBox.Show("Tuple Successfully Inserted!");
            }
            else
            {
                MessageBox.Show("Tuple Insertion Failed!");
            }
        }


        private void update_btn_Click(object sender, EventArgs e)
        {
            // creating connection using conn string
            SqlConnection sqlconn = new SqlConnection(conn);
            // writing query
            string query = "Update STUDENT Set Std_Name = @name, Std_Age = @age where Std_Id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            // getting parameters from textboxes
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", textBox3.Text);
            // opening connection
            sqlconn.Open();
            // ExecuteNonQuery() returns the number of rows that are
            // affected after the sql query is run
            int report = cmd.ExecuteNonQuery();
            // closing connection
            sqlconn.Close();

            // if the number of affected rows is greater than zero,
            // than it means that Insert process into the DataBase
            // was successful
            if (report > 0)
            {
                MessageBox.Show("Tuple Successfully Updated!");
            }
            else
            {
                MessageBox.Show("Tuple Updation Failed!");
            }
        }


        private void delete_btn_Click(object sender, EventArgs e)
        {
            // creating connection using conn string
            SqlConnection sqlconn = new SqlConnection(conn);
            // writing query
            string query = "Delete from STUDENT where Std_Id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            // getting parameters from textboxes
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            // opening connection
            sqlconn.Open();
            // ExecuteNonQuery() returns the number of rows that are
            // affected after the sql query is run
            int report = cmd.ExecuteNonQuery();
            // closing connection
            sqlconn.Close();

            // if the number of affected rows is greater than zero,
            // than it means that Insert process into the DataBase
            // was successful
            if (report > 0)
            {
                MessageBox.Show("Tuple Successfully Deleted!");
            }
            else
            {
                MessageBox.Show("Tuple Deletion Failed!");
            }
        }


        private void display_btn_Click(object sender, EventArgs e)
        {
            // creating connection using conn string
            SqlConnection sqlconn = new SqlConnection(conn);
            // writing query
            string query = "Select * from STUDENT";
            // connecting display button with grid
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlconn);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "STUDENT");
            dataGridView1.DataSource = dataSet.Tables["STUDENT"];
        }
    }
}