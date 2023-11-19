using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MalatyaMVC.Models.Mapping
{
    public class UrunlerMap : EntityTypeConfiguration<Urunler>
    {
        public UrunlerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Baslik)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.Aciklama)
                .IsFixedLength()
                .HasMaxLength(200);

            this.Property(t => t.Fiyat)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Urunler");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Baslik).HasColumnName("Baslik");
            this.Property(t => t.Aciklama).HasColumnName("Aciklama");
            this.Property(t => t.ResimYol).HasColumnName("ResimYol");
            this.Property(t => t.Fiyat).HasColumnName("Fiyat");
            this.Property(t => t.KategoriID).HasColumnName("KategoriID");
            this.Property(t => t.ResimID).HasColumnName("ResimID");

            // Relationships
            this.HasOptional(t => t.Kategori)
                .WithMany(t => t.Urunlers)
                .HasForeignKey(d => d.KategoriID);

        }
    }
}
