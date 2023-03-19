namespace Библиотека.Entities
{
     public class Loars
    {
        public int ID { get; set; }
        public string Dates_tamp { get; set; }
        public int BookId { get; set; }
        public List<Book> Book { get; set; }
        public int BorrowersId { get; set; }
        public List<Borrowers> Borrowers { get; set; }
        public int StudentId { get; set; }
        public List<Student> Student { get; set; }

    }
}
