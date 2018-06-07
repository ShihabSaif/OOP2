using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace DataLayer
{
    public class BookRepository : IBookRepository
    {
        public void Delete(Book obj)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                db.Books.Attach(obj);
                db.Books.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<Book> GetAll()
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                return db.Books.ToList();
            }
        }

        public Book GetById(int id)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                return db.Books.Find(id);
            }
        }

        public Book Insert(Book obj)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                db.Books.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(Book obj)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                db.Books.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
 
        public List<Book> CatagorySearch(String category)
        {
           // List<Book> book = new List<Book>();
            using (ProjectEntities db = new ProjectEntities())
            {
                var obj = (db.Books.Where(o => o.category == category));
                if (obj != null)
                    return obj.ToList();
                else
                    return null;
            }
        }

        public List<Book> BookSearch(string name)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                var obj = (db.Books.Where(o => o.name.Contains(name) || o.author.Contains(name)));
                if (obj != null)
                    return obj.ToList();
                else
                    return null;
            }
        }

        public Book GetByNameAndAuthor(string name, string author)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                var obj = (db.Books.Where(o => o.name == name && o.author == author));
                return obj.SingleOrDefault();
            }
        }

       

        public List<Book> GroupByMaximum()
        {
           using (ProjectEntities db = new ProjectEntities())
           {
                //var obj = (db.Books.Where(o => o.name == name && o.author == author));
              return db.Books.OrderByDescending(o => o.rating).ToList();
            }
        }
    }
}
