using KnowledgeWorkshop.WebAPI.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeWorkshop.WebAPI.DataAccess.Concrete.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");
            builder.Property(c => c.Name).IsRequired();
        }
    }
}