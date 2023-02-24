using Microsoft.EntityFrameworkCore;
using TeamLeadHelp.Models;

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
