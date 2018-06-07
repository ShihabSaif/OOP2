using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace DataLayer
{
    public class UserRepository : IUserRepository
    {
        public void Delete(User obj)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                db.Users.Attach(obj);
                db.Users.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<User> GetAll()
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                return db.Users.ToList();
            }
        }

        public User GetById(int id)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                return db.Users.Find(id);
            }
        }

        public User Insert(User obj)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                db.Users.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(User obj)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                db.Users.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Boolean DuplicateMail(String mail)
        {
            using(ProjectEntities db=new ProjectEntities())
            {
                if (db.Users.Any(o => o.email == mail))
                {
                    return true;
                }
                else
                    return false;
            }
        }

        //public Boolean LogIn(String mail, string password)
        //{
        //    using(ProjectEntities db=new ProjectEntities())
        //    {
        //        if (db.Users.Any(o => o.email == mail && o.password == password))
        //        {
        //            //var obj = (db.Users.Where(o => o.email == mail && o.password == password && o.type == "admin"));
        //            //return obj.SingleOrDefault()
        //            return true;
        //        }
        //        else
        //            return false;
        //    }
        //}

        public User LogIn(String mail, string password)
        {
            using(ProjectEntities db = new ProjectEntities())
            {
                if (db.Users.Any(o => o.email == mail && o.password == password))
                {
                    var obj = (db.Users.Where(o => o.email == mail && o.password == password));
                    return obj.SingleOrDefault();
                }
                else
                    return null;
            }
        }

        public User GetByEmail(string mail)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                var obj = (db.Users.Where(o => o.email == mail));
                return obj.SingleOrDefault();
            }
        }
    }
}
