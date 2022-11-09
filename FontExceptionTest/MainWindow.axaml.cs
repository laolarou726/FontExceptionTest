using Avalonia.Controls;
using Avalonia.Interactivity;

namespace FontExceptionTest
{
    public partial class MainWindow : Window
    {
        private bool _flag;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            _flag = !_flag;

            TestTheme.SetLanguage(_flag ? 1 : 0);
        }
    }
}