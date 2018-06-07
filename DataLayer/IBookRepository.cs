using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace DataLayer
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(int id);
        Book Insert(Book obj);
        void Update(Book obj);
        void Delete(Book obj);
        List<Book> CatagorySearch(String category);
        List<Book> BookSearch(string name);
        Book GetByNameAndAuthor(string name, string author);
        List<Book> GroupByMaximum();
    }
}
