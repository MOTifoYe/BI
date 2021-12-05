using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_2.Model
{
    class DateBase
    {
        public static IEnumerable<Student> GetStudents()
        {
            return new Student[]
            {
                new Student
                {
                    Name = "Ваня"
                },
                new Student
                {
                    Name = "Дима"
                },
                new Student
                {
                    Name = "Вася"
                },
                new Student
                {
                    Name = "Никита"
                }
            };
        }
    }
}
