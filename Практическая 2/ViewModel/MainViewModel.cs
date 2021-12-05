using DevExpress.Mvvm;
using Практическая_2.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_2.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public ObservableCollection<Student> Students { get; set; }
        public ICollectionView StudentsView { get; set; }
        public Student SelectedStudent { get; set; }
        public MainViewModel()
        {
            Students = new ObservableCollection<Student>(DateBase.GetStudents());
            Students.Remove(SelectedStudent);
        }
        //public ICommand Remove
        //{
        //    get
        //    {
        //        return new DelegateCommand<Student>((student) =>
        //       {
        //           Students.Remove(student);
        //       }, (student) => student != null);
        //    }
        //}
    }
}
