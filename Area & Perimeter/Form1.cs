namespace Area___Perimeter
{
    public partial class main_form : Form
    {
        // instantiating triangle and retangle forms
        triangle_form triangle = new triangle_form();
        rectangle_form rectangle = new rectangle_form();

        public main_form()
        {
            InitializeComponent();
        }
        // when you click trianlge_btn
        private void button1_Click(object sender, EventArgs e)
        {
            triangle.Show();
        }
        // when you click rectangle_btn
        private void rectangle_btn_Click(object sender, EventArgs e)
        {
            rectangle.Show();
        }
    }
}