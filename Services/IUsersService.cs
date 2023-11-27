using EcommerceApi.Entities;
using EcommerceApi.Models;

namespace EcommerceApi.Services
{
    public interface IUsersService
    {
        public string registerUser(UsersModel usersModel);
        public List<Users> getAllUsers();
        public string deleteUserWithEmail(string email);
    }
}
