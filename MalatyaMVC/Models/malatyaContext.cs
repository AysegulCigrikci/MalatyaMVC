using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MalatyaMVC.Models.Mapping;

namespace MalatyaMVC.Models
{
    public partial class malatyaContext : DbContext
    {
        static malatyaContext()
        {
            Database.SetInitializer<malatyaContext>(null);
        }

        public malatyaContext()
            : base("Name=malatyaContext")
        {
        }

        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Manset> Mansets { get; set; }
        public DbSet<Resimler> Resimlers { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KategoriMap());
            modelBuilder.Configurations.Add(new MansetMap());
            modelBuilder.Configurations.Add(new ResimlerMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UrunlerMap());
        }
    }
}
