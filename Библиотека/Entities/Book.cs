namespace Библиотека.Entities
{
    public class Book
    {
        public int ID { get; set; }
        public string Book_Title { get; set; }
        public string Author_book { get; set; }
        public string Publisher_book { get; set; }
        public string Source_book { get; set; }
        public string Status_book { get; set; }
        public int Cost_of_the_book { get; set; }
        public int BorrowersId { get; set; }
        public Borrowers Borrowers { get; set; }
    }
}
