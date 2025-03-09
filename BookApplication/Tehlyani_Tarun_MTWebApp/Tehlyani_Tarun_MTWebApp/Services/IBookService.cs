using Tehlyani_Tarun_MTWebApp.Models;

namespace Tehlyani_Tarun_MTWebApp.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetBooks();
        Task<Book> GetBook(int id);
        Task<bool> AddBook(Book book);
        Task<bool> DeleteBook(int id);
        Task<bool> UpdateBook(Book book);
    }
}
