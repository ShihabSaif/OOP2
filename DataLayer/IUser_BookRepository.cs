using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace DataLayer
{
    public interface IUser_BookRepository
    {
        List<User_Book> GetAll();
        User_Book GetById(int id);
        User_Book Insert(User_Book obj);
        void Update(User_Book obj);
        void Delete(User_Book obj);
        User_Book DuplicateCombination(int uid, int bid);
        List<User_Book> GetUserBooks(int uid);
        double AvarageRating(int uid);
        int CountBook(int uid);
        double SpecificAvarageRating(int bid);
    }
}
