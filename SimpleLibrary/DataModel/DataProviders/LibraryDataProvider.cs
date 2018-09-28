using SimpleLibrary.DataModel.BaseContext;
using SimpleLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.Ajax.Utilities;
using WebGrease.Css.Extensions;

namespace SimpleLibrary.DataModel.DataProviders
{
    public class LibraryDataProvider : ILibraryDataProvider
    {
        private static Entities entitiesContext = new Entities();
        private static LibraryDataProvider _instance = new LibraryDataProvider();
        private static ContextMapper contextMapper = new ContextMapper();
        public static LibraryDataProvider Instance
        {
            get { return _instance; }
        }

        public List<Book> getBooks(int isAvailable)
        {

            var query =
                (from books in entitiesContext.Books
                 where books.IsAvailable == (isAvailable == 1 ? true : isAvailable == 0 ? false : books.IsAvailable)
                 select books).ToList().Select(b => contextMapper.toObject(b)).ToList();

            List<Book> booksList = new List<Book>();

            return query;
        }

        public void borrowBook(int id)
        {
            entitiesContext.Books.Where(b => b.Id == id).ToList().ForEach(b => b.IsAvailable = !b.IsAvailable);
            entitiesContext.SaveChanges();
        }
    }
}