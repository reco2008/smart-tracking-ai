using Microsoft.EntityFrameworkCore;

namespace SmartTrackingAI.Data
{
    public class TrackingDbContext : DbContext
    {
        public TrackingDbContext(DbContextOptions<TrackingDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProtocolData> ProtocolData { get; set; }
    }
}
