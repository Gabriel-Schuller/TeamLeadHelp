using Microsoft.EntityFrameworkCore;
using TeamLeadHelp.Data.Models;

namespace TeamLeadHelp.Data
{
    public class DevTaskContext : DbContext
    {
        public DevTaskContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DevTask>  Tasks{ get; set; }
    }
}
