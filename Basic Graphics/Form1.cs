namespace Basic_Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // making graphics
            Graphics graphics = panel1.CreateGraphics();

            // making pen
            Pen pen = new Pen(Color.Black, 3);

            // making points
            PointF point1 = new PointF(100.0F, 100.0F);
            PointF point2 = new PointF(100.0F, 340.0F);

            // drawing diagonal line
            // graphics.DrawLine(pen, point1, point2);
            e.Graphics.DrawLine(pen, point1, point2);
            // draws a circle because width and height are equal
            e.Graphics.DrawEllipse(pen, 40.0F, 70.0F, 300.0F, 300.0F);
            e.Graphics.DrawLine(pen, 550, 200, 100, 200);
            e.Graphics.DrawLine(pen, 550, 200, 100, 200);
        }
    }
}