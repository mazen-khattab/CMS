using CMS.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Infrastructure.Persistence.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            // StudentProfile (1:1)
            builder.HasOne(u => u.Student)
                   .WithOne(s => s.AppUser)
                   .HasForeignKey<Student>(s => s.AppUserId)
                   .OnDelete(DeleteBehavior.Cascade);

            // InstructorProfile (1:1)
            builder.HasOne(u => u.Instructor)
                   .WithOne(i => i.AppUser)
                   .HasForeignKey<Instructor>(i => i.AppUserId)
                   .OnDelete(DeleteBehavior.Cascade);

            // AdminProfile (1:1)
            builder.HasOne(u => u.Admin)
                   .WithOne(a => a.AppUser)
                   .HasForeignKey<Admin>(a => a.AppUserId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
