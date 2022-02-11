using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Практическая_2._1
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

        private void BtnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            LBStudents.Items.Add(TBAddStudent.Text);
        }

        private void BtnRemoveStudent_Click(object sender, RoutedEventArgs e)
        {
            if (LBStudents.SelectedItem != null)
            {
                LBStudents.Items.Remove(LBStudents.SelectedItem);
                LBStudents.SelectedItem = null;
            }
        }

        private void BtnAddSetoff_Click(object sender, RoutedEventArgs e)
        {
            if (LBStudents.SelectedItem != null)
            {
                LBSetoff.Items.Add(LBStudents.SelectedItem);
                LBStudents.Items.Remove(LBStudents.SelectedItem);
                LBStudents.SelectedItem = null;

                LBMark.Items.Add(new TextBlock { Text = null });
            }
        }

        private void LBSetoff_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (LBSetoff.SelectedItem != null && LBMark.SelectedItem != null)
            {
                LBStudents.Items.Add(LBSetoff.SelectedItem);
                int SelIndex = LBSetoff.SelectedIndex;
                LBMark.Items.RemoveAt(SelIndex);
                LBSetoff.Items.RemoveAt(SelIndex);
                LBMark.SelectedItem = null;
                LBSetoff.SelectedItem = null;
            }
        }

        private void LBSetoff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LBMark.SelectedIndex = LBSetoff.SelectedIndex;
        }

        private void BtnAddNoSetoff_Click(object sender, RoutedEventArgs e)
        {
            if (LBStudents.SelectedItem != null)
            {
                LBNoSetoff.Items.Add(LBStudents.SelectedItem);
                LBStudents.Items.Remove(LBStudents.SelectedItem);
                LBStudents.SelectedItem = null;
            }
        }

        private void LBNoSetoff_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (LBNoSetoff.SelectedItem != null)
            {
                LBStudents.Items.Add(LBNoSetoff.SelectedItem);
                LBNoSetoff.Items.Remove(LBNoSetoff.SelectedItem);
                LBNoSetoff.SelectedItem = null;
            }
        }

        private void LBMark_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (LBMark.SelectedItem != null && LBSetoff.SelectedItem != null)
            {
                LBStudents.Items.Add(LBSetoff.SelectedItem);
                int SelIndex = LBSetoff.SelectedIndex;
                LBMark.Items.RemoveAt(SelIndex);
                LBSetoff.Items.RemoveAt(SelIndex);
                LBMark.SelectedItem = null;
                LBSetoff.SelectedItem = null;
            }
        }

        private void BtnEditMark_Click(object sender, RoutedEventArgs e)
        {
            if (LBMark.SelectedItem != null)
            {
                var si = LBMark.SelectedIndex;
                LBMark.Items.RemoveAt(si);
                LBMark.Items.Insert(si, TBMark.Text);
            }
        }

        private void LBMark_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LBSetoff.SelectedIndex = LBMark.SelectedIndex;
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            LBSetoff.Items.Clear();
            LBNoSetoff.Items.Clear();
            LBMark.Items.Clear();
            LBStudents.Items.Clear();
        }
    }
}
