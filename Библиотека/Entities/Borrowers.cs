namespace Библиотека.Entities
{
    public class Borrowers
    {
        public int ID { get; set; }
        public int Student_ID  { get; set; }
        public string Name_staff { get; set; }
        public int books_borrowed { get; set; }
        public int Book_ID { get; set; }
        public Book Book { get; set; }
        public List<Loars> Loars { get; set; }
    }
}
