using System.Collections.Generic;
using Entities;

namespace Business.Abstract
{
    public interface IPublisherService
    {
        IList<Publisher> GetAll();

        Publisher GetById(int Id);

        Publisher Add(Publisher publisher);

        Publisher Update(Publisher publisher);

        bool Delete(int Id);
    }
}