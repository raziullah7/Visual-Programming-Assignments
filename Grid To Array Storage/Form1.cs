namespace Grid_To_Array_Storage
{
    public partial class Form1 : Form
    {
        // public List<Student> students;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[,] record = new string[,]
            {
                { "Razi", "21", "GCU" },
                { "Taha", "20", "GCU" },
                { "Shoaib", "21", "GCU" }
            };

            //for (int i = 0; i < record.GetLength(0); i++)
            //{
            //    string[] row = new string[record.GetLength(1)];
            //    for (int j = 0; j < record.GetLength(1); j++)
            //    {
            //        row[j] = record[i, j];
            //        //this.dataGridView1.Rows.Add(name, rollNo, email);
            //    }
            //    dataGridView1.Rows.Add(row);
            //}

            //foreach (string item in record)
            //{
            //    dataGridView1.Rows.Add(item.., item.., item..);
            //}

            dataGridView1.DataSource = record;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}