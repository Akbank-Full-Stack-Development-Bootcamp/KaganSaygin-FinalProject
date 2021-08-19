using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities;
using Entities.DTO;

namespace DataAccess.Concrete
{
    public class EfBookDal : EfEntityRepositoryBase<Book, BookStoreDBContext>, IBookDal
    {
        public List<BookListDTO> BookList()
        {
            using (BookStoreDBContext context = new BookStoreDBContext())
            {
                var result = (from bo in context.Books
                    join au in context.Authors on bo.AuthorId equals au.Id
                    join pu in context.Publishers on bo.PublisherId equals pu.Id
                    select new BookListDTO
                    {
                        Id = bo.Id,
                        Name = bo.Name,
                        Price = bo.Price,
                        CoverImage = bo.CoverImage,
                        Author = au.FirstName + " " + au.LastName,
                        Publisher = pu.Name,
                        AuthorId = au.Id,
                        PublisherId = pu.Id
                    }).ToList();
                return result;
            }
        }

        public List<BookListDTO> GetByAuthor(int authorId)
        {
            using (BookStoreDBContext context = new BookStoreDBContext())
            {
                var result = (from bo in context.Books
                    join au in context.Authors on bo.AuthorId equals au.Id
                    join pu in context.Publishers on bo.PublisherId equals pu.Id
                    where au.Id == authorId
                    select new BookListDTO
                    {
                        Id = bo.Id,
                        Name = bo.Name,
                        Price = bo.Price,
                        CoverImage = bo.CoverImage,
                        Author = au.FirstName + " " + au.LastName,
                        Publisher = pu.Name,
                        AuthorId = au.Id,
                        PublisherId = pu.Id
                    }).ToList();
                return result;
            }
        }

        public List<BookListDTO> GetByPublisher(int publisherId)
        {
            using (BookStoreDBContext context = new BookStoreDBContext())
            {
                var result = (from bo in context.Books
                    join au in context.Authors on bo.AuthorId equals au.Id
                    join pu in context.Publishers on bo.PublisherId equals pu.Id
                    where pu.Id == publisherId
                    select new BookListDTO
                    {
                        Id = bo.Id,
                        Name = bo.Name,
                        Price = bo.Price,
                        CoverImage = bo.CoverImage,
                        Author = au.FirstName + " " + au.LastName,
                        Publisher = pu.Name,
                        AuthorId = au.Id,
                        PublisherId = pu.Id
                    }).ToList();
                return result;
            }
        }

        public List<BookListDTO> GetByCategory(int categoryId)
        {
            using (BookStoreDBContext context = new BookStoreDBContext())
            {
                var result = (from bo in context.Books
                    join au in context.Authors on bo.AuthorId equals au.Id
                    join pu in context.Publishers on bo.PublisherId equals pu.Id
                    join ca in context.Categories on bo.CategoryId equals ca.Id
                    where ca.Id == categoryId
                    select new BookListDTO
                    {
                        Id = bo.Id,
                        Name = bo.Name,
                        Price = bo.Price,
                        CoverImage = bo.CoverImage,
                        Author = au.FirstName + " " + au.LastName,
                        Publisher = pu.Name,
                        AuthorId = au.Id,
                        PublisherId = pu.Id
                    }).ToList();
                return result;
            }
        }

        public List<BookListDTO> Search(string name)
        {
            using (BookStoreDBContext context = new BookStoreDBContext())
            {
                var result = (from bo in context.Books
                    join au in context.Authors on bo.AuthorId equals au.Id
                    join pu in context.Publishers on bo.PublisherId equals pu.Id
                    join ca in context.Categories on bo.CategoryId equals ca.Id
                    where bo.Name.Contains(name) || pu.Name.Contains(name) || au.FirstName.Contains(name) || au.LastName.Contains(name)
                    select new BookListDTO
                    {
                        Id = bo.Id,
                        Name = bo.Name,
                        Price = bo.Price,
                        CoverImage = bo.CoverImage,
                        Author = au.FirstName + " " + au.LastName,
                        Publisher = pu.Name,
                        AuthorId = au.Id,
                        PublisherId = pu.Id
                    }).ToList();
                return result;
            }
        }

        public BookDetailDTO BookDetail(int bookId)
        {
            using (BookStoreDBContext context = new BookStoreDBContext())
            {
                var result = (from bo in context.Books
                    join au in context.Authors on bo.AuthorId equals au.Id
                    join pu in context.Publishers on bo.PublisherId equals pu.Id
                    join ca in context.Categories on bo.CategoryId equals ca.Id
                    where bo.Id == bookId
                    select new BookDetailDTO()
                    {
                        Id = bo.Id,
                        Name = bo.Name,
                        Price = bo.Price,
                        CoverImage = bo.CoverImage,
                        Author = au.FirstName + " " + au.LastName,
                        Description = bo.Description,
                        Publisher = pu.Name,
                        Category = ca.Name,
                        CategoryId = ca.Id,
                        AuthorId = au.Id,
                        PublisherId = pu.Id
                    }).FirstOrDefault();
                return result;
            }
        }
    }
}