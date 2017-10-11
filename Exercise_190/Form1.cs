namespace Exercise_190
{
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Length = 300;
            DrawArea = new Bitmap(drawField.Size.Width, drawField.Size.Height);
            DrawRectangle();
        }

        private int Length { get; }
        private Bitmap DrawArea { get; }

        private void DrawRectangle()
        {
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            var Pen = new Pen(Brushes.Black);
        }
    }
}