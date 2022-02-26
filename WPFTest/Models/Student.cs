using System;

namespace WPFTest
{
    class Student
    {
        private double _nameD = double.NaN;
        private string _name = "DefaultName";
        public string Name
        {
            get
            {
                if (double.IsNaN(_nameD))
                {
                    return _name;
                }
                return _nameD.ToString();
            }
            internal set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Укажите имя", value);
                var res = Double.TryParse(value, out double NameD);
                if (res)
                    _nameD = NameD;
                if (!res)
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