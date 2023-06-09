using ApiAgendaTupBrande.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ApiAgendaTupBrande.Data
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);
        }
        
    }
}
