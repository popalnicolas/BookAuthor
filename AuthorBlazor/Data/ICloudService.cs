using AuthorBlazor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorBlazor.Data
{
    public interface ICloudService
    {
        Task<IList<Book>> GetBooks();
        Task AddBook(Book book);
        Task AddAuthor(Author author);
        Task DeleteBook(int isbn);
    }
}
