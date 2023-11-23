using EcommerceApi.Entities;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base
        (options)
    {
    }
    public DbSet<Users> Users => Set<Users>();
    public DbSet<Cart> Cart => Set<Cart>();
    public DbSet<OrderItems> OrderItems => Set<OrderItems>();
    public DbSet<Orders> Orders => Set<Orders>();
    public DbSet<Products> Products => Set<Products>();
}