using AuthorBlazor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AuthorBlazor.Data
{
    public class CloudServices : ICloudService
    {
        private string uri = "https://localhost:44380/";
        private readonly HttpClient client;

        public CloudServices()
        {
            client = new HttpClient();
        }

        public async Task AddAuthor(Author author)
        {
            StringContent content = new StringContent(JsonSerializer.Serialize(author), Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync(uri + "author", content);
        }

        public async Task AddBook(Book book)
        {
            StringContent content = new StringContent(JsonSerializer.Serialize(book), Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync(uri + "book", content);
        }

        public async Task DeleteBook(int isbn)
        {
            
            await client.DeleteAsync(uri + "book/" + isbn);
        }

        public async Task<IList<Book>> GetBooks()
        {
            string message = await client.GetStringAsync(uri + "book");
            List<Book> result = JsonSerializer.Deserialize<List<Book>>(message);
            return result;
        }
    }
}
