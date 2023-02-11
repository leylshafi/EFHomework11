using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFHomework11.Models;

namespace EFHomework11.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("nvarchar(10)");

        builder.HasOne(x => x.Faculty)
            .WithMany(x => x.Groups)
            .HasForeignKey(x => x.Id_Faculty);
    }
}
