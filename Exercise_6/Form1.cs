namespace Exercise_6
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private int _number;

        public Form1()
        {
            InitializeComponent();
            testButton.Enabled = false;
            textBox1.Enabled = false;
        }

        private void Generate()
        {
            _number = new Random().Next(0, 300);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            generateButton.Enabled = false;
            testButton.Enabled = true;
            textBox1.Enabled = true;
            Generate();
        }

        public void TestNumber(int number)
        {
            if (number == _number)
            {
                MessageBox.Show("Richtig!" + Environment.NewLine + "Generieren Sie mit 'Neu' eine neue Zahl");
                _number = 0;

                label1.ForeColor = Color.Black;
                label1.Text = "Noch keine Eingabe getätigt.";

                textBox1.Enabled = false;
                testButton.Enabled = false;

                generateButton.Enabled = true;
            }
            else if (number > _number)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Die gesuchte Zahl ist kleiner.";
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Die gesuchte Zahl ist größer.";
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            try
            {
                TestNumber(int.Parse(textBox1.Text));
            }
            catch
            {
                // Ignored
            }
        }
    }
}