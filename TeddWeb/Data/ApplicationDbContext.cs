using Microsoft.EntityFrameworkCore;

using TeddWeb.Model;

namespace TeddWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Category> Category { get; set; }
    }
}
