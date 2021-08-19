using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public IList<Author> GetAll()
        {
            return _authorDal.GetAll().OrderBy(x=> x.FirstName).ToList();
        }

        public Author GetById(int Id)
        {
            return _authorDal.Get(a => a.Id == Id);
        }

        public Author Add(Author author)
        {
            _authorDal.Add(author);
            return author;
        }

        public Author Update(Author author)
        {
            _authorDal.Update(author);
            return author;
        }

        public bool Delete(int Id)
        {
            var deleteAuthor = GetById(Id);
            if (deleteAuthor == null) return false;
            _authorDal.Delete(deleteAuthor);
            return true;
        }
    }
}