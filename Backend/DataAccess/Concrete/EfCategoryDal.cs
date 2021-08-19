using System.Collections.Generic;
using DataAccess.Abstract;
using Entities;
using Entities.DTO;

namespace DataAccess.Concrete
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, BookStoreDBContext>, ICategoryDal
    {
       
    }
}