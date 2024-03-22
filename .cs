using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool UpKeyPressed { get; private set; }
        public bool DownKeyPressed { get; private set; }
        public bool LeftKeyPressed { get; private set; }
        public bool RightKeyPressed { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UP_KEY_BUTTON(object sender, RoutedEventArgs e)
        {
            UpKeyPressed = true;
        }

        private void DOWN_KEY_Click(object sender, RoutedEventArgs e)
        {
            DownKeyPressed = true;
        }

        private void LEFT_KEY_Click(object sender, RoutedEventArgs e)
        {
            LeftKeyPressed = true;
        }

        private void RIGHT_KEY_Click(object sender, RoutedEventArgs e)
        {
            RightKeyPressed = true;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    UpKeyPressed = true;
                    break;
                case Key.S:
                    DownKeyPressed = true;
                    break;
                case Key.A:
                    LeftKeyPressed = true;
                    break;
                case Key.D:
                    RightKeyPressed = true;
                    break;
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    UpKeyPressed = false;
                    break;
                case Key.S:
                    DownKeyPressed = false;
                    break;
                case Key.A:
                    LeftKeyPressed = false;
                    break;
                case Key.D:
                    RightKeyPressed = false;
                    break;
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void INVENTORY_1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UP_KEY_Copy_Click(object sender, RoutedEventArgs e)
        {


        }

        private void UP_KEY_Click(object sender, RoutedEventArgs e)
        {


        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }
    }
}
