using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete
{
    public class EfPublisherDal : EfEntityRepositoryBase<Publisher, BookStoreDBContext>, IPublisherDal
    {
    }
}