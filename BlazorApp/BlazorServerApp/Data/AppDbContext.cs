using BlazorServerApp.Models.Entities;
using BlazorServerApp.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Member> Members { get; set; }
    }
}
