using System;

namespace WPFTest
{
    class Student
    {
        private string _name = "DefaultName";
        public string Name
        {
            get => _name;
            internal set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Укажите имя", value);
                _name = value;
            }
        }
        private int _mark;
        public string Mark
        {
            get { return _mark.ToString(); }
            internal set
            {
                bool v = int.TryParse(value, out int inMark);
                if (!v)
                    throw new ArgumentException("Укажите корректное значение оценки", value);
                if (inMark < 2 || inMark > 5)
                    throw new ArgumentException("Значение оценки должно быть от 2 до 5", value);
                _mark = inMark;
            }
        }
    }
}