using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Graphics_Test
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
            Pen bluePen = new Pen(Color.Blue, 5);

            // making points
            PointF point1 = new PointF(700.0F, 50.0F);
            PointF point2 = new PointF(700.0F, 250.0F);

            e.Graphics.DrawLine(bluePen, point1, point2);
            e.Graphics.DrawEllipse(bluePen, 40.0F, 70.0F, 200.0F, 200.0F);


            Pen blackPen = new Pen(Color.Black, 5);
            blackPen.DashStyle = DashStyle.Dash;
            //float[] dashValues = { 3,3,3,3,3,3 };
            //blackPen.DashPattern = dashValues;
            e.Graphics.DrawLine(blackPen, new Point(50, 5), new Point(305, 40));

            Pen solidBlackPen = new Pen(Color.Black, 5);
            e.Graphics.DrawRectangle(solidBlackPen, 300, 50, 300, 150);

            //SolidBrush myBrush = new SolidBrush(Color.Red);
            //Graphics formGraphics;
            //formGraphics = CreateGraphics();
            //formGraphics.FillEllipse(myBrush, new Rectangle(200, 200, 30, 30));
            //myBrush.Dispose();
            //formGraphics.Dispose();

            Brush blackBrush = new SolidBrush(Color.Black);
            Brush dashedBrush = new HatchBrush(HatchStyle.Vertical, Color.Gray, Color.White);

            e.Graphics.FillEllipse(blackBrush, new Rectangle(450, 300, 200, 200));
            e.Graphics.FillEllipse(dashedBrush, new Rectangle(150, 300, 200, 200));
            

        }
    }
}