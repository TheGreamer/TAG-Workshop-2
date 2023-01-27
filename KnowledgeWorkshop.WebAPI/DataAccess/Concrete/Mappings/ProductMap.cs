using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using KnowledgeWorkshop.WebAPI.Entity.Concrete;

namespace KnowledgeWorkshop.WebAPI.DataAccess.Concrete.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Brand).IsRequired();
        }
    }
}