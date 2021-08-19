using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IList<Category> GetAll()
        {
            return _categoryDal.GetAll().OrderBy(x=> x.Name).ToList();
        }

        public Category GetById(int Id)
        {
            return _categoryDal.Get(c => c.Id == Id);
        }

        public Category Add(Category category)
        {
            _categoryDal.Add(category);
            return category;
        }

        public Category Update(Category category)
        {
            _categoryDal.Update(category);
            return category;
        }

        public bool Delete(int Id)
        {
            var deleteCategory = GetById(Id);
            if (deleteCategory == null) return false;
            _categoryDal.Delete(deleteCategory);
            return true;
        }
    }
}