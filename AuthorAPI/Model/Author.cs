using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AuthorApi.Model
{
    public class Author
    {
        [Key]
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [MaxLength(15)]
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }
        [MaxLength(15)]
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
        [JsonPropertyName("books")]
        public ICollection<Book> Books { get; set; }
    }
}
