using Entities;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAuthorService
    {
        IList<Author> GetAll();

        Author GetById(int Id);

        Author Add(Author author);

        Author Update(Author author);

        bool Delete(int Id);
    }
}