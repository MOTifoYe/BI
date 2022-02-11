using System.Windows;
using System.Windows.Input;

namespace меню_и_панели
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Message_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("It message for you", "Message");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            MenuItem_Message.IsEnabled = false;
        }

        private void MenuItem_Unchecked(object sender, RoutedEventArgs e)
        {
            MenuItem_Message.IsEnabled = true;
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("It message for you", "Message");

        }

        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            TBMessage.IsEnabled = TBMessage.IsEnabled ? false : true;
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Description", "Message");

        }

        private void TBCheck_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TBMessage.IsEnabled = !TBMessage.IsEnabled;
        }
    }
}
