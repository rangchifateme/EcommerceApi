using EcommerceApi.Entities;
using EcommerceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApi.Services
{
    public class UsersService: IUsersService
    {
        private readonly ApplicationDbContext _context;
        public UsersService(ApplicationDbContext context) { 
        _context = context;
        }
        public string registerUser(Users user) {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }

        public List<Users> getAllUsers() {
         return _context.Users.ToList();
        }

        public string deleteUserWithEmail(string email)
        {
            try
            {
                _context.Remove(_context.Users.Single(t => t.EmailAddress == email));
                _context.SaveChanges();
                return "successful";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string updateUserWithUserId(Users user)
        {
            try {
                var usr = _context.Users.First(u => u.Id == user.Id);
                usr.FirstName = user.FirstName;
                usr.PhoneNumber = user.PhoneNumber;
                usr.LasttName = user.LasttName; 
                usr.Password = user.Password;
                usr.EmailAddress = user.EmailAddress;
                _context.SaveChanges();
                return "successful";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
