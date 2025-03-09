using Tehlyani_Tarun_MTWebApp.Models;

namespace Tehlyani_Tarun_MTWebApp.Services
{
    public class BookService : IBookService
    {
        string url = "https://localhost:7135/api/Books";
        HttpClient _client;

        public BookService(HttpClient client)
        {
            _client = client;
        }

        public async Task<bool> AddBook(Book book)
        {
            var response = await _client.PostAsJsonAsync<Book>(url, book);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteBook(int id)
        {
            var response = await _client.DeleteAsync($"{url}/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<Book> GetBook(int id)
        {
            var book = await _client.GetFromJsonAsync<Book>($"{url}/{id}");
            return book ?? new Book();
        }

        public async Task<List<Book>> GetBooks()
        {
            var book = await _client.GetFromJsonAsync<List<Book>>(url);
            return book ?? new List<Book>();
        }

        public async Task<bool> UpdateBook(Book book)
        {
            var response = await _client.PutAsJsonAsync<Book>($"{url}/{book.Id}", book);
            return response.IsSuccessStatusCode;
        }
    }
}
