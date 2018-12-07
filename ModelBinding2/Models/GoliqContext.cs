using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ModelBinding2.Models.Mapping;

namespace ModelBinding2.Models
{
    public partial class GoliqContext : DbContext
    {
        static GoliqContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<GoliqContext>());
        }

        public GoliqContext()
            : base("Name=GoliqContext")
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
