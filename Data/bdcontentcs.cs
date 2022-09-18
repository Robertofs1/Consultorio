using CrudWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudWeb.Data
{
    public class DbContent : DbContext
    {
        public DbContent(DbContextOptions<DbContent> options) : base(options) {}
        
         public DbSet<ContactModel> Contatos { get; set; }
    }
}