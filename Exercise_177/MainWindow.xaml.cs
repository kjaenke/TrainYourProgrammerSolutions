namespace Exercise_177
{
    using System.Windows;
    using System.Windows.Input;
    using System.Windows.Media;

    public partial class MainWindow
    {
        private readonly SolidColorBrush _brushFalse = Brushes.Red;


        private readonly SolidColorBrush _brushTrue = Brushes.Green;
        private bool[] _boButtonFree = {true, false, false, false};

        private uint _number;

        public MainWindow()
        {
            InitializeComponent();
            BtReset_OnClick(null, null);
        }

        private void SetColor()
        {
            BtExpand.Background = _boButtonFree[0] ? _brushTrue : _brushFalse;

            Bt22.Background = _boButtonFree[1] ? _brushTrue : _brushFalse;

            Bt7.Background = _boButtonFree[2] ? _brushTrue : _brushFalse;

            Bt13.Background = _boButtonFree[3] ? _brushTrue : _brushFalse;
        }

        private void Error() => MessageBox.Show("input not okay! just a positive three-digit even number (100 ... 998)");

        private void Bt13_OnClick(object sender, RoutedEventArgs e)
        {
            if (!_boButtonFree[3])
                return;
            _number /= 13;
            TbInout.Text = _number.ToString();
            _boButtonFree[3] = false;
            SetColor();
        }

        private void Bt7_OnClick(object sender, RoutedEventArgs e)
        {
            if (!_boButtonFree[2])
                return;
            _number /= 7;
            TbInout.Text = _number.ToString();
            _boButtonFree[2] = false;
            SetColor();
        }

        private void Bt22_OnClick(object sender, RoutedEventArgs e)
        {
            if (!_boButtonFree[1])
                return;
            _number /= 22;
            TbInout.Text = _number.ToString();
            _boButtonFree[1] = false;
            SetColor();
        }

        private void BtExpand_OnClick(object sender, RoutedEventArgs e)
        {
            if (!_boButtonFree[0])
                return;

            var boContentOk = uint.TryParse(TbInout.Text, out var content);
            if (!boContentOk)
                Error();
            else if (TbInout.Text.Length != 3)
                Error();
            else
            {
                if (content % 2 == 1)
                    content--;
                _number = content * 1001;
                TbInout.Text = _number.ToString();
                _boButtonFree = new[] {false, true, true, true};
                SetColor();
            }
        }

        private void TbInout_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                BtExpand_OnClick(null, null);
        }

        private void BtReset_OnClick(object sender, RoutedEventArgs e)
        {
            _boButtonFree = new[] {true, false, false, false};
            SetColor();
            TbInout.Clear();
            TbInout.Focus();
        }
    }
}