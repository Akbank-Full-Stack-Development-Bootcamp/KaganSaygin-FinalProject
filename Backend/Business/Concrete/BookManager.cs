using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System.Collections.Generic;
using System.Linq;
using Entities.DTO;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public IList<BookListDTO> GetAll()
        {
            return _bookDal.BookList().OrderByDescending(x=> x.Id).ToList();
        }

        public IList<BookListDTO> GetByAuthor(int authorId)
        {
            return _bookDal.GetByAuthor(authorId).OrderBy(x=> x.Name).ToList();
        }

        public IList<BookListDTO> GetByPublisher(int publisherId)
        {
            return _bookDal.GetByPublisher(publisherId).OrderBy(x=> x.Name).ToList();
        }

        public IList<BookListDTO> GetByCategory(int categoryId)
        {
            return _bookDal.GetByCategory(categoryId).OrderBy(x=> x.Name).ToList();
        }

        public IList<BookListDTO> Search(string bookName)
        {
            return _bookDal.Search(bookName).OrderBy(x=> x.Name).ToList();
        }

        public BookDetailDTO GetById(int Id)
        {
            return _bookDal.BookDetail(Id);
        }

        public Book Add(Book book)
        {
            _bookDal.Add(book);
            return book;
        }

        public Book Update(Book book)
        {
            _bookDal.Update(book);
            return book;
        }

        public bool Delete(int Id)
        {
            var deleteBook = GetById(Id);
            if (deleteBook == null) return false;
            _bookDal.Delete(deleteBook);
            return true;
        }
    }
}