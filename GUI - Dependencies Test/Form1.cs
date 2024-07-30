namespace GUI___Dependencies_Test
{
    public partial class Form1 : Form
    {

        // Declare these variables at the class level
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Drag(object sender, MouseEventArgs e)
        {
            // Cast the sender to a Control, which could be your form or any control within it
            Control c = sender as Control;

            // On mouse down, set _dragging to true and capture the start point
            if (e.Button == MouseButtons.Left)
            {
                _dragging = true;
                _startPoint = new Point(e.X, e.Y);
            }
            else
            {
                _dragging = false;
            }

            // On mouse move, if dragging, move the control to the new position
            if (_dragging)
            {
                Point p = c.PointToScreen(e.Location);
                c.Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
            }
        }

    }
}
