using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=TEKNIKDESTEK;database=CvProjectDb;integrated security=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Interests> Interestss { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Skills> Skillss { get; set; }
       
    }
}
