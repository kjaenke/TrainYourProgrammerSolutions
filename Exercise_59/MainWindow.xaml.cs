namespace Exercise_59
{
    using System;
    using System.Windows.Controls;

    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Birthdate_OnSelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Birthdate.SelectedDate != null && Birthdate.SelectedDate.Value.Day == DateTime.Today.Day && Birthdate.DisplayDate.Month == DateTime.Today.Month)
            {
                Description.Content = $"Herzlichen Glückwunsch zum {HowOld()}.";
            }
        }

        private int HowOld() => (Birthdate.DisplayDate.Year - DateTime.Now.Year) * -1;
    }
}