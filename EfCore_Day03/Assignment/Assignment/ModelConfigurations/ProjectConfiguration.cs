using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Assignment.ModelConfigurations
{
    public class ProjectConfiguration: IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {

            builder.Property(p => p.Id)
            .UseIdentityColumn(seed: 10, increment: 10);

            builder.Property(p => p.Name)
            .HasMaxLength(50)
            .HasDefaultValue("OurProject")
            .IsRequired();

            builder.Property(p => p.Cost)
            .HasColumnType("money");

            builder.ToTable("Projects", t =>
            {
                t.HasCheckConstraint("CK_Project_Cost_Range",
                    "[Cost] >= 500000 AND [Cost] <= 3500000");
            });
        }
    }
}
