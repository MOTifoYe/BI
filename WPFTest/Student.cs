using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace WpfApp3
{
    class Student : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (String.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Укажите имя.");
                }
            }
        }
        private int _mark;
        public int Mark
        {
            get { return _mark; }
            set
            {
                if (value < 2 || value > 5)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 2 and 5.");
                _mark = value;
            }
        }
    }
}
