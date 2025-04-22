using Microsoft.EntityFrameworkCore;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EclipseWorks.DeveloperEvaluation.ORM.Mapping;

public class HistoryConfiguration : IEntityTypeConfiguration<History>
{
    public void Configure(EntityTypeBuilder<History> builder)
    {
        builder.ToTable("Histories");
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");
    }
}
