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
                    Name = "Employee",
                    NormalizedName = "EM"
                },
                new IdentityRole
                {
                    Name = "Sales Person",
                    NormalizedName = "SP"
                },
                new IdentityRole
                {
                    Name = "Individual Customer",
                    NormalizedName = "IN"
                },
                new IdentityRole
                {
                    Name = "Store Contact",
                    NormalizedName = "SC"
                },
                new IdentityRole
                {
                    Name = "Vendor Contact",
                    NormalizedName = "VC"
                },
                new IdentityRole
                {
                    Name = "General Contact",
                    NormalizedName = "GC"
                }
                );
        }
    }
}
