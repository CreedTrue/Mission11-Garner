namespace Mission11_Garner.Models.ViewModels
{
    public class ItemListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
