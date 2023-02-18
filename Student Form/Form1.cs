namespace Student_Form
{
    public partial class Form1 : Form
    {
        // data members
        string name, rollNo, email;
        // -------------------------------------------------
        // constructor
        public Form1()
        {
            InitializeComponent();
        }
        // -------------------------------------------------
        // textboxes
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            rollNo = textBox2.Text;
        }
        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            email = textBox3.Text;
        }
        // -------------------------------------------------
        // bottons
        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add(name, rollNo, email);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Credentials Submitted!");
        }
    }
}