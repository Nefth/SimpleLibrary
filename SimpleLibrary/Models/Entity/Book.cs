using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleLibrary.Models
{
    public class Book
    {
        
        private string title;
        private string author;
        private int issueYear;
        private Boolean isAvaible;

        public Book(string title, string author, int issueYear, bool isAvaible)
        {
            
            this.title = title;
            this.author = author;
            this.issueYear = issueYear;
            this.isAvaible = isAvaible;
        }

     
    }
}