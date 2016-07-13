using System.Data.Entity;

namespace OnlineStore.Data
{
    public class DataContext: DbContext, IDbContext
    {
        public DataContext()
            : base(nameOrConnectionString: "OnlineStoreDataContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;
        }

        public DbSet<Models.Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        } 
    }
}
