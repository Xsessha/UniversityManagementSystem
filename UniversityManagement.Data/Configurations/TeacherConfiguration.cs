using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Data.Configurations;

public class TeacherConfiguration
    : IEntityTypeConfiguration<Teacher>
{
    public void Configure(
        EntityTypeBuilder<Teacher> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FullName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Department)
            .IsRequired();
    }
}