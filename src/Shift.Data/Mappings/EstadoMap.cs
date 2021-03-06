using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shift.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shift.Data.Mappings
{
    public class EstadoMap : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.Property(c => c.Id)
                .IsRequired()
                .HasColumnName("Id");

            builder.Property(c => c.Nome)
                .IsRequired();
        }
    }
}
