using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Bio.Model.Entity;
namespace Bio.Data.Contedxt
{
    public class BioContext : DbContext
    {
        public BioContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Login> Login{ get; set; }
        
    }
}
