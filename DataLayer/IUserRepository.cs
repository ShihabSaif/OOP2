using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace DataLayer
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User GetById(int id);
        User Insert(User obj);
        void Update(User obj);
        void Delete(User obj);
        Boolean DuplicateMail(String mail);
        //Boolean LogIn(String mail, string password);
        User LogIn(String mail, string password);
        User GetByEmail(string mail);
    }
}
