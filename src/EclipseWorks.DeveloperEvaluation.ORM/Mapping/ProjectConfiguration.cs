using Microsoft.EntityFrameworkCore;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EclipseWorks.DeveloperEvaluation.ORM.Mapping;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.ToTable("Projects");
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");
        builder.Property(u => u.ProjectNumber).IsRequired().HasMaxLength(20);
    }
}
