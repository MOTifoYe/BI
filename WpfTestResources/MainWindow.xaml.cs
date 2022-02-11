using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;


namespace WpfTest2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<ResourceDictionary> resources = new List<ResourceDictionary>();
        public MainWindow()
        {
            InitializeComponent();
            
            resources.Add( Application.LoadComponent(new Uri("ToggleThemeButton.xaml", UriKind.Relative)) as ResourceDictionary);
            resources.Add( Application.LoadComponent(new Uri("Light.xaml", UriKind.Relative)) as ResourceDictionary);
            resources.Add( Application.LoadComponent(new Uri("Dark.xaml", UriKind.Relative)) as ResourceDictionary);

            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resources[0]);
            Application.Current.Resources.MergedDictionaries.Add(resources[1]);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void toggleTheme_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Remove(resources[1]);
            Application.Current.Resources.MergedDictionaries.Add(resources[2]);   
        }

        private void toggleTheme_Unchecked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Remove(resources[2]);
            Application.Current.Resources.MergedDictionaries.Add(resources[1]);
        }
    }
}
