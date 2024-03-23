
namespace goaslind_mission11.Models
{
    public class EFBookStoreRepository : IBookStoreRepository
    {
        private BookstoreContext _context;
        public EFBookStoreRepository(BookstoreContext temp) {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
