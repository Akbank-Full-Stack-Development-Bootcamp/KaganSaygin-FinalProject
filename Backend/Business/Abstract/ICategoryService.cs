using Entities;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IList<Category> GetAll();

        Category GetById(int Id);

        Category Add(Category category);

        Category Update(Category category);

        bool Delete(int Id);
    }
}