namespace Exercise_8
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text.Replace(' ', '0'), out int _))
            {
                try
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
                catch
                {
                    // Ignored
                }
            }
        }
    }
}