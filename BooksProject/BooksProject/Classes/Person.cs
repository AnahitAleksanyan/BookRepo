using BooksProject.Enums;

namespace BooksProject.Classes
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
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
