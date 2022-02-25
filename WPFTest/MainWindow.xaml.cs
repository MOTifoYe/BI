using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Windows;
using System.Windows.Controls;

namespace WPFTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        MetroDialogSettings metroDialogSettings = new MetroDialogSettings() { AnimateHide = false, AnimateShow = false };

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Add(object s, RoutedEventArgs e)
        {
            try
            {
                Student student = new() { Name = name.Text, Mark = mark.Text };
                dataGrid1.Items.Add(student);
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("Некорректные данные", ex.Message, settings: metroDialogSettings);
            }

        }

        private void Del(object sender, RoutedEventArgs e)
        {
            dataGrid1.Items.Remove(dataGrid1.SelectedItem);
        }

        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            string? result = await this.ShowInputAsync("Авторизация", "Введите пароль", settings: metroDialogSettings);

            if (string.IsNullOrWhiteSpace(result)) return;

            if (result == "123")
                await this.ShowMessageAsync("Авторизация", "Авторизация пройдена", settings: metroDialogSettings);
            else
                await this.ShowMessageAsync("Авторизация", $"Вы ввели: {result}", settings: metroDialogSettings);
        }
        void PrintText(object sender, SelectionChangedEventArgs args)
        {
            ListBoxItem lbi = ((ListBox)sender).SelectedItem as ListBoxItem;
            tb.Text = $"You selected {lbi.Content}.";
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
