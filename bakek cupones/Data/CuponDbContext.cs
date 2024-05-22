using Microsoft.EntityFrameworkCore;
using LuegoPago.Models;

namespace LuegoPago.Data
{
    public class CuponDbContext : DbContext
    {
        public CuponDbContext(DbContextOptions<CuponDbContext> options): base(options){

        }
        public DbSet<Cupon> Cupones { get; set; }
    }
}

