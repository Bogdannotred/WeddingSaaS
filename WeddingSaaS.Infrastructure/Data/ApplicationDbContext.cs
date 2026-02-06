using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using WeddingSaaS.Core.Entities;

namespace WeddingSaas.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        :base(options)
    {
        
    }

    public DbSet<Wedding> Weddings {get; set;}
    public DbSet<Photo> Photos {get;set;}
}