using EcommerceApi.Models;

namespace EcommerceApi.Services
{
    public interface IUsersService
    {
        public string registerUser(UsersModel usersModel);
    }
}
