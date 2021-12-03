using Microsoft.EntityFrameworkCore;
using Models;

namespace SearchWebAppService
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() => Database.EnsureCreated();

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<PilotProject> PilotProjects { get; set; }

        public DbSet<PilotTestingPhase> PilotTestingPhases { get; set; }

        public DbSet<ProjectStage> ProjectStages { get; set; }

        public DbSet<Startup> Startups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DataBase.db;");
        }
    }
}
