using N66_HT_1.Models.Entities;
using N66_HT_1.Persistence.DataAccess;
using N66_HT_1.Services.Interfaces;

namespace N66_HT_1.Services
{
    public class BookService : IBookService
    {
        private readonly AppDataContext _dbContext;

        public BookService(AppDataContext appDataContext)
        {
            _dbContext = appDataContext;
        }

        public IQueryable<Book> Get() => _dbContext.Books;

        public ValueTask<IEnumerable<Book>> GetByAuthorIdAsync(Guid authorId) => new(_dbContext.Books.Where(book => book.AuthorId == authorId));

        public ValueTask<Book> GetByIdAsync(Guid id) => new(_dbContext.Books.FirstOrDefault(book => book.Id == id));
        public async ValueTask<Book> CreatAsync(Book book)
        {
            await _dbContext.Books.AddAsync(book);

            await _dbContext.SaveChangesAsync();

            return book;
        }
        public async ValueTask<Book> UpdateAsync(Book book)
        {
            var updatingBook = await GetByIdAsync(book.Id);

            if (updatingBook is null)
                return null;

            updatingBook.AuthorId = book.AuthorId;
            updatingBook.Title = book.Title;
            updatingBook.Description = book.Description;

            await _dbContext.SaveChangesAsync();

            return updatingBook;
        }
        public async ValueTask<Book> DeleteAsync(Guid id)
        {
            var deletedBook = await GetByIdAsync(id);

            if (deletedBook is null)
                return null;

            _dbContext.Books.Remove(deletedBook);

            await _dbContext.SaveChangesAsync();

            return deletedBook;
        }
    }
}
