namespace Area___Perimeter
{
    // Shape is the parent class of Triangle(form2)
    // and Rectangle(form3) classes
    public class Shape
    {
        // most shapes will need these to be computed
        protected double area;
        protected double perimeter;
        // writing virtual methods to make their
        // implementation in derived classes compulsory
        public virtual void Area() { area = 0; }
        public virtual void Perimeter() { perimeter = 0; }
    }

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