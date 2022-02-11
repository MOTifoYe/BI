using DevExpress.Mvvm;
using System;

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
                    throw new ApplicationException($"Значение оценки должно быть от 2 до 5");
                _mark = value;
            }
        }
    }
}
