using EcommerceApi.Entities;

namespace EcommerceApi.Services
{
    public class OrdersService: IOrdersService
    {
        private readonly ApplicationDbContext _context;
        public OrdersService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
