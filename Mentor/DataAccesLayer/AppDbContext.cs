using Mentor.Models;
using Microsoft.EntityFrameworkCore;

namespace Mentor.DataAccesLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Courses> courses { get; set; }


    }
}
