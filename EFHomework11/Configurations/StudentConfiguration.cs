using EFHomework11.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHomework11.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasColumnType("nvarchar(15)");

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasColumnType("nvarchar(25)");

        builder.HasOne(x => x.Group)
            .WithMany(x => x.Students)
            .HasForeignKey(x => x.Id_Group);
    }
}