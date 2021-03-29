﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AuthorBlazor.Model
{
    public class Book
    {
        [Key]
        [JsonPropertyName("isbn")]
        public int ISBN { get; set; }
        [MaxLength(40)]
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("publicationYear")]
        public int PublicationYear { get; set; }
        [JsonPropertyName("numOfPages")]
        public int NumOfPages { get; set; }
        [JsonPropertyName("genre")]
        public string Genre { get; set; }
    }
}
