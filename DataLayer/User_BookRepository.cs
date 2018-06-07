using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace DataLayer
{
    public class User_BookRepository : IUser_BookRepository
    {
        public void Delete(User_Book obj)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                db.User_Book.Attach(obj);
                db.User_Book.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<User_Book> GetAll()
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                return db.User_Book.ToList();
            }
        }

        public User_Book GetById(int id)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                return db.User_Book.Find(id);
            }
        }

        public User_Book Insert(User_Book obj)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                db.User_Book.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(User_Book obj)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                db.User_Book.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public User_Book DuplicateCombination(int uid, int bid)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                if (db.User_Book.Any(o => o.user_id == uid && o.book_id == bid))
                {
                    return db.User_Book.Where(o => o.user_id == uid && o.book_id == bid).SingleOrDefault();
                }
                else
                    return null;
            }
        }

        public List<User_Book> GetUserBooks(int uid)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                var obj = (db.User_Book.Where(o => o.user_id == uid));
                if (obj != null)
                    return obj.ToList();
                else
                    return null;
            }
        }

        public double AvarageRating(int uid)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                var avg = db.User_Book.Where(o => o.user_id == uid).Average(o => o.rating);
                return Convert.ToDouble(avg);
            }
        }

        public int CountBook(int uid)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                var count = db.User_Book.Where(o => o.user_id == uid).Count();
                return Convert.ToInt32(count);
            }
        }

        public double SpecificAvarageRating(int bid)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                var avg = db.User_Book.Where(o => o.book_id == bid).Average(o => o.rating);
                return Convert.ToDouble(avg);
            }
        }
    }
}
