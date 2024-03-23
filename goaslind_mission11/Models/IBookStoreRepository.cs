namespace goaslind_mission11.Models
{
    public interface IBookStoreRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
