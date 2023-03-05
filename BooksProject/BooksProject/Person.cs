using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksProject
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age > 2 && age < 99)
                {
                    age = value;
                }
            }
        }
    }
}
