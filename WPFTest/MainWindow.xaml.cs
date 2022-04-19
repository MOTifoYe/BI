using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WPFTest.Models;
using WPFTest.ViewModels;

namespace WPFTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        // Настройка МетроДиалога
        MetroDialogSettings metroDialogSettings = new MetroDialogSettings() { AnimateHide = false, AnimateShow = false };
        
        private readonly MediaViewModel mediaViewModel;

        public MainWindow()
        {
            InitializeComponent();

            this.mediaViewModel = new MediaViewModel
            {
                MediaLists = new ObservableCollection<MediaList>()
            };
            this.DataContext = this.mediaViewModel;

            for (int i = 0; i < 15; i++)
                this.mediaViewModel.MediaLists.Add(new MediaList($"VOC {i}", $"ALB {i}"));


            // ListBox.Example Microsoft
            for (int i = 1; i < 100; i++)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                listBoxItem.Content = $"Item {i}";
                lbEx.Items.Add(listBoxItem);
            }
        }

        private async void Add(object s, RoutedEventArgs e)
        {
            try
            {
                Student student = new() { Name = name.Text, Mark = mark.Text };
                dgStudent.Items.Add(student);
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync(title: Const.DATA_INVALID,
                                            message: ex.Message,
                                            settings: metroDialogSettings);
            }

        }

        private void Del(object sender, RoutedEventArgs e)
        {
            dgStudent.Items.Remove(dgStudent.SelectedItem);
        }

        private async void Signup_Click(object sender, RoutedEventArgs e)
        {
            string? result = await this.ShowInputAsync(title: Const.AUTHORIZE,
                                                       message: Const.PASSWORD_INPUT,
                                                       settings: metroDialogSettings);

            if (string.IsNullOrWhiteSpace(result)) return;

            if (result == Const.PASSWORD_VALID)
                await this.ShowMessageAsync(title: Const.AUTHORIZE,
                                            message: Const.AUTHORIZE_SUCCESS,
                                            settings: metroDialogSettings);
            else
                await this.ShowMessageAsync(title: Const.AUTHORIZE,
                                            message: $"Вы ввели: {result}",
                                            settings: metroDialogSettings);
        }

        void PrintText(object sender, SelectionChangedEventArgs args)
        {
            ListBoxItem lbi = ((ListBox)sender).SelectedItem as ListBoxItem;
            tbEx.Text = $"You selected {lbi.Content}";
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btAddMediaList_Click(object sender, RoutedEventArgs e)
        {
            MediaList mediaList = new MediaList(tbVocalist.Text, tbAlbum.Text);
            this.mediaViewModel.MediaLists.Add(mediaList);
        }

        private void btRemoveMedia_Click(object sender, RoutedEventArgs e)
        {
            if (this.mediaViewModel.SelectedMedia == null)
                return;
            MediaList mediaList = this.mediaViewModel.SelectedMedia;
            this.mediaViewModel.MediaLists.Remove(mediaList);
        }
    }
}
