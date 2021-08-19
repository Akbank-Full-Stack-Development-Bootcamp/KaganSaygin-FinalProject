using Entities;
using Entities.DTO;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBookService
    {
        IList<BookListDTO> GetAll();

        IList<BookListDTO> GetByAuthor(int authorId);

        IList<BookListDTO> GetByPublisher(int publisherId);

        IList<BookListDTO> GetByCategory(int categoryId);
        IList<BookListDTO> Search(string bookName);

        BookDetailDTO GetById(int Id);

        Book Add(Book book);

        Book Update(Book book);

        bool Delete(int Id);
    }
}