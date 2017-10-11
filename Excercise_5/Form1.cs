namespace Excercise_5
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Fill();
        }

        public void Fill()
        {
            leftListBox.SelectionMode = SelectionMode.MultiExtended;
            leftListBox.Items.Add("Januar");
            leftListBox.Items.Add("Febuar");
            leftListBox.Items.Add("März");
            leftListBox.Items.Add("April");
            leftListBox.Items.Add("Mai");
            leftListBox.Items.Add("Juni");

            rightListBox.SelectionMode = SelectionMode.MultiExtended;
            rightListBox.Items.Add("Juli");
            rightListBox.Items.Add("August");
            rightListBox.Items.Add("September");
            rightListBox.Items.Add("Oktober");
            rightListBox.Items.Add("November");
            rightListBox.Items.Add("Dezember");
        }

        private void toRightButton_Click(object sender, EventArgs e)
        {
            var counter = leftListBox.SelectedItems.Count;
            for (var i = 0; i < counter; i++)
            {
                rightListBox.Items.Add(leftListBox.SelectedItems[0]);
                leftListBox.Items.Remove(leftListBox.SelectedItems[0]);
            }
            if (leftListBox.Items.Count == 0)
            {
                toRightButton.Enabled = false;
            }
            toLeftButton.Enabled = true;
        }

        private void toLeftButton_Click(object sender, EventArgs e)
        {
            var counter = rightListBox.SelectedItems.Count;
            for (var i = 0; i < counter; i++)
            {
                leftListBox.Items.Add(rightListBox.SelectedItems[0]);
                rightListBox.Items.Remove(rightListBox.SelectedItems[0]);
            }
            if (rightListBox.Items.Count == 0)
            {
                toLeftButton.Enabled = false;
            }
            toRightButton.Enabled = true;
        }
    }
}