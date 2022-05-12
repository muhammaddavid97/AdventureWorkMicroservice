using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Entities.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Name = "EM",
                    NormalizedName = "Employee"
                },
                new IdentityRole
                {
                    Name = "SP",
                    NormalizedName = "Sales Person"
                },
                new IdentityRole
                {
                    Name = "IN",
                    NormalizedName = "Individual Customer"
                },
                new IdentityRole
                {
                    Name = "SC",
                    NormalizedName = "Store Contact"
                },
                new IdentityRole
                {
                    Name = "VC",
                    NormalizedName = "Vendor Contact"
                },
                new IdentityRole
                {
                    Name = "GC",
                    NormalizedName = "General Contact"
                }
                );
        }
    }
}
