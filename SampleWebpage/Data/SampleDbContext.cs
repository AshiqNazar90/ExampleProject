using Microsoft.EntityFrameworkCore;
using SampleWebpage.Models;

namespace SampleWebpage.Data
{
    public class SampleDbContext:DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext>options):base(options)
        {

        }
        public DbSet<Sample> Example1 { get; set; }
        public DbSet<Collect> Example2 { get; set; }
    }
}
