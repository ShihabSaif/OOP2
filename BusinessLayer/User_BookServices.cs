using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using ModelLayer;

namespace BusinessLayer
{
    public class User_BookServices
    {
        static IUser_BookRepository repository;

        static User_BookServices()
        {
            repository = new User_BookRepository();
        }

        public static List<User_Book> GetAll()
        {
            return repository.GetAll();
        }

        public static User_Book GetById(int id)
        {
            return repository.GetById(id);
        }

        public static User_Book Insert(User_Book obj)
        {
            return repository.Insert(obj);
        }

        public static void Update(User_Book obj)
        {
            repository.Update(obj);
        }

        public static void Delete(User_Book obj)
        {
            repository.Delete(obj);
        }

        public static User_Book DuplicateCombination(int uid, int bid)
        {
            return repository.DuplicateCombination(uid, bid);
        }

        public static List<User_Book> GetUserBooks(int uid)
        {
            return repository.GetUserBooks(uid);
        }

        public static double AvarageRating(int uid)
        {
            return repository.AvarageRating(uid);
        }

        public static int CountBook(int uid)
        {
            return repository.CountBook(uid);
        }

        public static double SpecificAvarageRating(int bid)
        {
            return repository.SpecificAvarageRating(bid);
        }
    }
}
