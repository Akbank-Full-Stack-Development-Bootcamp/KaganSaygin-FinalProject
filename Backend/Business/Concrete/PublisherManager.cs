using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class PublisherManager : IPublisherService
    {
        private IPublisherDal _publisherDal;

        public PublisherManager(IPublisherDal publisherDal)
        {
            _publisherDal = publisherDal;
        }

        public IList<Publisher> GetAll()
        {
            return _publisherDal.GetAll().OrderBy(x=> x.Name).ToList();
        }

        public Publisher GetById(int Id)
        {
            return _publisherDal.Get(p => p.Id == Id);
        }

        public Publisher Add(Publisher publisher)
        {
            _publisherDal.Add(publisher);
            return publisher;
        }

        public Publisher Update(Publisher publisher)
        {
            _publisherDal.Update(publisher);
            return publisher;
        }

        public bool Delete(int Id)
        {
            var deletePublisher = GetById(Id);
            if (deletePublisher == null) return false;
            _publisherDal.Delete(deletePublisher);
            return true;
        }
    }
}