using muscatApi.Models;
using muscatApi.Controllers;
using Microsoft.EntityFrameworkCore;

namespace muscatApi.Services
{
    public class UserService : IUserService
    {
        private muscatApiContext _context;

        public UserService(muscatApiContext context)
        {
            _context = context;
        }

        // CRUD operation

        public List<MyUser> GetAll()
        {
            return _context.MyUsers
                .ToList();
        }
        
        public MyUser? GetById(int id)
        {
            return _context.MyUsers
                .Include(p => p.Id)
                .Include(p => p.Email)
                .Include(p => p.Name)
                .SingleOrDefault(p => p.Id == id);
        }

        public MyUser Create(MyUser newUser)
        {
            _context.MyUsers.Add(newUser);
            _context.SaveChanges();

            return newUser;
        }

        // UpdatePassword-  아직 미구현
        
        public bool DeleteById(int id)
        {
            var userToDelete = _context.MyUsers.Find(id);
            if (userToDelete != null)
            {
                _context.MyUsers.Remove(userToDelete);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }



    }
   
}
