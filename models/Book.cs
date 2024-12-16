

namespace bookRent.models
{
    internal class Book
    {
        public string bookName { get; set; }
        public int pageCount { get; set; }
        public string writer { get; set; }
        public int bookStock { get; set; }

        public List<int> requestedBookIndexes { get; set; } = new List<int>();
    }
}
