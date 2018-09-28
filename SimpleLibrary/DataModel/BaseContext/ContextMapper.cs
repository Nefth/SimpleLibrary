using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleLibrary.Models;

namespace SimpleLibrary.DataModel.BaseContext
{
    public class ContextMapper
    {
        public Book toObject (Books books)
        {
            return new Book(books.Id, books.Title, books.Author, books.IssueYear, books.IsAvailable);
        }
    }
}