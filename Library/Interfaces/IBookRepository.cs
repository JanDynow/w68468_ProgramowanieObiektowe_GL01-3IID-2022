﻿using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interfaces
{
    public interface IBookRepository: IBaseRepository<Book, int>
    {
        List<Book> GetBooksByAuthor(string author);
        List<Book> GetBooksByPublishYear(int year);
    }
}
