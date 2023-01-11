using DomainLayer.Common;


namespace DomainLayer.Entities
{
    public class Library :BaseEntitiy
    {
        public string Name { get; set; }
        public int SeatCount { get; set; }
        public List<Book> Books { get; set; }
    }
}
