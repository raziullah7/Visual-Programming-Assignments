using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Student_Record
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // get elements from grid like Excel and 
        // store it in array in the background
        // (research in dataGridView)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[,] record = new string[,]
            {
            { "0066", "Razi", "CS", "GCU" },
            { "0024", "Taha", "CS", "GCU" },
            { "0027", "Shoaib", "CS", "GCU" }
            };

            for (int i = 0; i < record.GetLength(0); i++)
            {
                string[] row = new string[record.GetLength(1)];
                for (int j = 0; j < record.GetLength(1); j++)
                {
                    row[j] = record[i, j];
                    //this.dataGridView1.Rows.Add(name, rollNo, email);
                }
                dataGridView1.Rows.Add(row);
            }
        }
    }
}