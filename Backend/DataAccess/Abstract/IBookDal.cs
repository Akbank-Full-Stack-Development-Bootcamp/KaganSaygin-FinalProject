using System.Collections.Generic;
using Entities;
using Entities.DTO;

namespace DataAccess.Abstract
{
    public interface IBookDal : IEntityRepository<Book>
    {
        List<BookListDTO> BookList();
        List<BookListDTO> GetByAuthor(int authorId);
        List<BookListDTO> GetByPublisher(int publisherId);
        List<BookListDTO> GetByCategory(int categoryId);
        List<BookListDTO> Search(string bookName);
        BookDetailDTO BookDetail(int bookId);
    }
}