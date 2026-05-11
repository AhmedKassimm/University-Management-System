using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityProject.Domin.Entities;

namespace UniversityProject.Infrastructure.Data.Cofiguration
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).IsRequired().UseIdentityColumn(10, 10);
            builder.HasKey(D => D.Id);
            builder.Property(D => D.Name).IsRequired().HasMaxLength(200).HasColumnType("nvarchar");
            builder.HasMany(D => D.DepartmentSubjects).WithOne(D => D.Department).HasForeignKey(D => D.SubjectId);
        }
    }
}
