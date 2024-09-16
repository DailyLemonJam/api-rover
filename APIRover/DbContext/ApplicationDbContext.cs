namespace APIRover.DbContext;

using APIRover.Entities;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<HttpRequestInfo> HistoryRequests { get; set; }
}
