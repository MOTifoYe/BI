using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;

namespace Практическая_3._1__Калькулятор_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string result;
        public MainWindow()
        {
            InitializeComponent();
        }

        private string Calc(string v)
        {
            try
            {
                result = new DataTable().Compute(new Regex(@"[/*\-+]+$").Replace(v.Replace(",", "."), ""), null).ToString();
            }
            catch (Exception ex)
            {
                result = "0";
                string message = $"Во время вычислений произошла ошибка.\nРезультат будет заменен нулём и\nпередан к дальнейшим преобразованиям.\n--\n{ex.Message}";
                MessageBox.Show(message, "Ошибка!");
            }
            return result;
        }

        private void One_Click(object sender, RoutedEventArgs e) => tb1.Text += 1;
        private void Two_Click(object sender, RoutedEventArgs e) => tb1.Text += 2;
        private void Tri_Click(object sender, RoutedEventArgs e) => tb1.Text += 3;
        private void Four_Click(object sender, RoutedEventArgs e) => tb1.Text += 4;
        private void Five_Click(object sender, RoutedEventArgs e) => tb1.Text += 5;
        private void Six_Click(object sender, RoutedEventArgs e) => tb1.Text += 6;
        private void Seven_Click(object sender, RoutedEventArgs e) => tb1.Text += 7;
        private void Eight_Click(object sender, RoutedEventArgs e) => tb1.Text += 8;
        private void Nine_Click(object sender, RoutedEventArgs e) => tb1.Text += 9;
        private void Zero_Click(object sender, RoutedEventArgs e) => tb1.Text += 0;

        private void Clear_Click(object sender, RoutedEventArgs e) => tb1.Text = "";
        private void Plus_Click(object sender, RoutedEventArgs e) => tb1.Text += "+";
        private void Minus_Click(object sender, RoutedEventArgs e) => tb1.Text += "-";
        private void Mul_Click(object sender, RoutedEventArgs e)
        {
            if (tb1.Text.Length > 0 && !(
                    tb1.Text[tb1.Text.Length - 1].Equals('+') ||
                    tb1.Text[tb1.Text.Length - 1].Equals('-') ||
                    tb1.Text[tb1.Text.Length - 1].Equals('*') ||
                    tb1.Text[tb1.Text.Length - 1].Equals('/') ))
            { tb1.Text += "*"; }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text += (tb1.Text.Length == 0) ? "": 
                tb1.Text[tb1.Text.Length - 1].Equals('+') ||
                tb1.Text[tb1.Text.Length - 1].Equals('-') ||
                tb1.Text[tb1.Text.Length - 1].Equals('*') ||
                tb1.Text[tb1.Text.Length - 1].Equals('/') ? "" : "/";
        }

        private void Ravno_Click(object sender, RoutedEventArgs e) => tb1.Text = Calc(tb1.Text);
        private void Sqrt_Click(object sender, RoutedEventArgs e) => tb1.Text = tb1.Text == "" ? "" : Math.Sqrt(double.Parse(Calc(tb1.Text))).ToString();
        private void Sinus_Click(object sender, RoutedEventArgs e) => tb1.Text = tb1.Text == "" ? "" : Math.Sin(double.Parse(Calc(tb1.Text)) * (Math.PI / 180)).ToString();
        private void Arcsin_Click(object sender, RoutedEventArgs e) => tb1.Text = tb1.Text == "" ? "" : Math.Asin(double.Parse(Calc(tb1.Text))).ToString();
        private void Cos_Click(object sender, RoutedEventArgs e) => tb1.Text = tb1.Text == "" ? "" : Math.Cos(double.Parse(Calc(tb1.Text)) * (Math.PI / 180)).ToString();
        private void Arccos_Click(object sender, RoutedEventArgs e) => tb1.Text = tb1.Text == "" ? "" : Math.Acos(double.Parse(Calc(tb1.Text))).ToString();
        private void Tg_Click(object sender, RoutedEventArgs e) => tb1.Text = tb1.Text == "" ? "" : Math.Tan(double.Parse(Calc(tb1.Text)) * (Math.PI / 180)).ToString();
        private void Arctg_Click(object sender, RoutedEventArgs e) => tb1.Text = tb1.Text == "" ? "" : Math.Atan(double.Parse(Calc(tb1.Text))).ToString();
        private void Ctg_Click(object sender, RoutedEventArgs e) => tb1.Text = tb1.Text == "" ? "" : (1 / Math.Tan(double.Parse(Calc(tb1.Text)) * (Math.PI / 180))).ToString();
        private void Arcctg_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(Calc(tb1.Text));
            if (x >= 0)
            {
                tb1.Text = (Math.Asin(1 / Math.Sqrt(1 + Math.Pow(x, 2)))).ToString();
            }

            else if (x <= 0)
            {
                tb1.Text = (Math.PI - Math.Asin(1 / Math.Sqrt(1 + Math.Pow(x, 2)))).ToString();
            }
        }


    }
}