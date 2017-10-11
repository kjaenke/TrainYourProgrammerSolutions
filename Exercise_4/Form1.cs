namespace Exercise_4
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private readonly List<string> listItems = new List<string>();

        public Form1()
        {
            InitializeComponent();

            listItems.Add("Opel");
            listItems.Add("Audi");
            listItems.Add("Renault");
            listItems.Add("Mercedes");
            listBox.Items.AddRange(listItems.ToArray());

            deleteBtn.Enabled = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count == 0)
            {
                listBox.Items.AddRange(listItems.ToArray());
                deleteBtn.Enabled = false;
            }
            else
                listBox.Items.Remove(listBox.SelectedItem);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listBox.SelectedItem != null) | (listBox.Items.Count == 0))
                deleteBtn.Enabled = true;
            else
                deleteBtn.Enabled = false;
        }
    }
}