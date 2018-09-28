using System;
using System.Collections.Generic;
using SimpleLibrary.DataModel.BaseContext;
using SimpleLibrary.Models;

namespace SimpleLibrary.DataModel
{
    public interface ILibraryDataProvider
    {
        List<Book> getBooks (int isAvailable);

    }
}