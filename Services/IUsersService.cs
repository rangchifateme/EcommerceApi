using EcommerceApi.Entities;
using EcommerceApi.Models;

namespace EcommerceApi.Services
{
    public interface IUsersService
    {
        public string registerUser(Users usersModel);
        public List<Users> getAllUsers();
        public string deleteUserWithEmail(string email);
        public string updateUserWithUserId(Users user);
        public List<Users> getUserInfoByFirstname(string firstname);
    }
}
