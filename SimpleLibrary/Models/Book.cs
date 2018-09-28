using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleLibrary.Models
{
    public class Book
    {
        public Book()
        {
        }

        public Book(int id, string title, string author, int? issueYear, Boolean isAvailable)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.issueYear = issueYear;
            this.isAvailable = isAvailable;
        }


        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int? issueYear { get; set; }
        public Boolean isAvailable { get; set; }
    }
}