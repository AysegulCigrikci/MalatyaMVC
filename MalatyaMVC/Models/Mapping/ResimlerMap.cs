using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MalatyaMVC.Models.Mapping
{
    public class ResimlerMap : EntityTypeConfiguration<Resimler>
    {
        public ResimlerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Resimler");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.ResimYolu).HasColumnName("ResimYolu");
            this.Property(t => t.ResimId).HasColumnName("ResimId");
        }
    }
}
