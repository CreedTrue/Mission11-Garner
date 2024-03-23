namespace Mission11_Garner.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
