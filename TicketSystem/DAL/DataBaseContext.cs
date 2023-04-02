using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Diagnostics.Metrics;
using TicketSystem.DAL.Entities;

namespace TicketSystem.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }
        public DbSet<Ticket> Tickets { get; set; }

    }
}
