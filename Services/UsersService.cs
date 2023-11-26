using EcommerceApi.Entities;
using EcommerceApi.Models;

namespace EcommerceApi.Services
{
    public class UsersService: IUsersService
    {
        private readonly ApplicationDbContext _context;
        public UsersService(ApplicationDbContext context) { 
        _context = context;
        }
        public string registerUser(UsersModel usersModel) {
            Users user = new Users
            {
                Id = usersModel.Id,
                EmailAddress = usersModel.EmailAddress,
                FirstName = usersModel.FirstName,
                LasttName = usersModel.LastName,
                Password = usersModel.Password,
                PhoneNumber = usersModel.PhoneNumber
            };

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
    }
}
