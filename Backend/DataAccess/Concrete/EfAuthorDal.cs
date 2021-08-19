using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete
{
    public class EfAuthorDal : EfEntityRepositoryBase<Author, BookStoreDBContext>, IAuthorDal
    {
    }
}