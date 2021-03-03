using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book GetById(int id);
        List<Book> GetByAuthorId(int id);
        void Add(Book book);
        void Delete(Book book);
        void Update(Book book);
    }
}
