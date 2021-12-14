using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            TMessage.IsEnabled = TMessage.IsEnabled ? false : true;
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Description", "Message");

        }
    }
}
