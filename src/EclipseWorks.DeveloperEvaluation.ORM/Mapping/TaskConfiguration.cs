using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EclipseWorks.DeveloperEvaluation.ORM.Mapping;

public class TaskConfiguration : IEntityTypeConfiguration<Domain.Entities.Task>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Task> builder)
    {
        builder.ToTable("Tasks");
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");
    }
}
