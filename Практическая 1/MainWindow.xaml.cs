using System;
using System.Windows;

namespace WpfApp1
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

        private void Вычислить(object sender, RoutedEventArgs e)
        {
            //textOut.Content = textIn.Text;
            if (x2.IsChecked == true)
            {
                textOut.Content = Convert.ToString(int.Parse(textIn.Text), 2);
            }
            if (x8.IsChecked == true)
            {
                textOut.Content = Convert.ToString(int.Parse(textIn.Text), 8);
            }
        }
        private void Сброс(object sender, RoutedEventArgs e)
        {
            textIn.Text = "";
            textOut.Content = "";
            x2.IsChecked = false;
            x8.IsChecked = false;
        }
        private void Выход(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
