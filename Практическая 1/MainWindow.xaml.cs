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
            if (x2.IsChecked==true)
            {
                textOut.Content = Convert.ToString(int.Parse(textIn.Text), 2);
            }
            if (x8.IsChecked==true)
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
