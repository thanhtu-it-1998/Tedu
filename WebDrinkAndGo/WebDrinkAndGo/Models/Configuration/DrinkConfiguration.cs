using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDrinkAndGo.Models.Entities;

namespace WebDrinkAndGo.Models.Configuration
{
    public class DrinkConfiguration: IEntityTypeConfiguration<Drink>
    {
        public void Configure(EntityTypeBuilder<Drink> builder)
        {
            builder.ToTable("Drinks");
            builder.HasKey(x => x.DrinkId);
            builder.Property(x => x.Price).HasColumnType("decimal(18, 2)");
        }
    }
}