namespace Forms_from_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // configuring form
            this.Text = "Welcome";
            this.BackColor = Color.Cornsilk;
            this.MaximizeBox = false;

            // adding label l1
            Label l1 = new Label();
            l1.Text = "Aqua";
            l1.Font = new Font("Arial", 16);
            l1.Location = new Point(50, 50);
            Controls.Add(l1);

            // adding label l2
            Label l2 = new Label
            {
                Text = "Red",
                Location = new Point(50, 100),
                Font = new Font("Arial", 16)
            };
            Controls.Add(l2);

            // adding label l3
            Label l3 = new Label
            {
                Text = "Purple",
                Location = new Point(50, 150),
                Font = new Font("Arial", 16)
            };
            Controls.Add(l3);

            // adding label l4
            Label l4 = new Label
            {
                Text = "Blue",
                Location = new Point(50, 200),
                Font = new Font("Arial", 16)
            };
            Controls.Add(l4);

            // adding events
            l1.DoubleClick += L1_DoubleClick;
            l2.DoubleClick += L2_DoubleClick;
            l3.DoubleClick += L3_DoubleClick;
            l4.DoubleClick += L4_DoubleClick;
        }

                // implementing events
        // this implementation throws an exception for
        // reasons only Allah knows of
        //private void The_DoubleClick(object? sender, EventArgs e)
        //{
        //    this.BackColor = Color.FromName(this.Text);
        //}

        private void L1_DoubleClick(object? sender, EventArgs e)
        {
            BackColor = Color.Aqua;
        }

        private void L2_DoubleClick(object? sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void L3_DoubleClick(object? sender, EventArgs e)
        {
            BackColor = Color.Purple;
        }

        private void L4_DoubleClick(object? sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}