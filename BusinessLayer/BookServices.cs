using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using ModelLayer;

namespace BusinessLayer
{
    public class BookServices
    {
        static IBookRepository repository;

        static BookServices()
        {
            repository = new BookRepository();
        }

        public static List<Book> GetAll()
        {
            return repository.GetAll();
        }

        public static Book GetById(int id)
        {
            return repository.GetById(id);
        }

        public static Book Insert(Book obj)
        {
            return repository.Insert(obj);
        }

        public static void Update(Book obj)
        {
            repository.Update(obj);
        }

        public static void Delete(Book obj)
        {
            repository.Delete(obj);
        }

        public static List<Book> CatagorySearch(String category)
        {
            return repository.CatagorySearch(category);
        }

        public static List<Book> BookSearch(string name)
        {
            return repository.BookSearch(name);
        }

        public static Book GetByNameAndAuthor(string name, string author)
        {
            return repository.GetByNameAndAuthor(name, author);
        }

        public static List<Book> GroupByMaximum()
        {
            return repository.GroupByMaximum();
        }
    }
}
