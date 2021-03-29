using Microsoft.EntityFrameworkCore;
using SportsBetting.Data.Models;

namespace SportsBetting.Data
{
   public class EventsDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public EventsDbContext(DbContextOptions<EventsDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
