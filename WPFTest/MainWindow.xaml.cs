using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;


namespace WpfApp3
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

        private void Add(object s, RoutedEventArgs e)
        {
            try
            {
                Student student = new Student { Name = name.Text, Mark = int.Parse(mark.Text) };
                dataGrid1.Items.Add(student);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Del(object sender, RoutedEventArgs e)
        {
            dataGrid1.Items.Remove(dataGrid1.SelectedItem);
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            PasswordWindow passwordWindow = new PasswordWindow();

            if (passwordWindow.ShowDialog() == true)
            {
                if (passwordWindow.Password == "123")
                    MessageBox.Show("Авторизация пройдена");
                else
                    MessageBox.Show("Неверный пароль");
            }
            else
            {
                MessageBox.Show("Авторизация не пройдена");
            }
        }

    }

    //class MainViewModel : BaseVM
    //{
    //    private ObservableCollection<Student> _students = new ObservableCollection<Student>();
    //    public ObservableCollection<Student> Students { get { return _students; } }
    //    public ICollectionView StudentsView { get; set; }

    //    public MainViewModel()
    //    {


    //    }

    //    public ICommand Add
    //    {
    //        get
    //        {
    //            return new DelegateCommand(() =>
    //            {
    //                Students.Add(new Student() { Name = "ds", Group = "234" });
    //            });
    //        }
    //    }


    //    //private void Add(object s, RoutedEventArgs e)
    //    //{
    //    //    Student student = new Student { Name = name.Text, Group = group.Text };
    //    //    Students.Add(student);
    //    //}

    //}
}
