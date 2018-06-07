using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using ModelLayer;

namespace BusinessLayer
{
    public class UserServices
    {
        static IUserRepository repository;

        static UserServices()
        {
            repository = new UserRepository();
        }

        public static List<User> GetAll()
        {
            return repository.GetAll();
        }

        public static User GetById(int id)
        {
            return repository.GetById(id);
        }

        public static User Insert(User obj)
        {
            return repository.Insert(obj);
        }

        public static void Update(User obj)
        {
            repository.Update(obj);
        }

        public static void Delete(User obj)
        {
            repository.Delete(obj);
        }

        public static Boolean DuplicateMail(String mail)
        {
            Boolean result = repository.DuplicateMail(mail);
            return result;
        }

        public static User GetByEmail(string mail)
        {
            return repository.GetByEmail(mail);
        }

        public static User LogIn(String mail, string password)
        {
            return repository.LogIn(mail, password);
        }
    }
}
