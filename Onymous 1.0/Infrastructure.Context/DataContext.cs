using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using static Aplication.ConectionString.ConectionString;

namespace Infrastructure.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
            :base(GetWithWindows)
        {
            Configuration.LazyLoadingEnabled = false;

            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
