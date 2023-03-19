using System.Collections.Generic;

namespace Библиотека.Entities
{
    public class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public int Heigh { get; set; }
        public int Weigh { get; set; }
        public Book Book { get; set; }
        public List<Borrowers> Borrowers { get; set; }

    }
}
