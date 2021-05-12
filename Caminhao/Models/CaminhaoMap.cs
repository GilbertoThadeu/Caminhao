using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caminhao.Models
{
    public class CaminhaoMap : IEntityTypeConfiguration<Caminhao>
    {
        public void Configure(EntityTypeBuilder<Caminhao> builder)
        {
            builder.ToTable("Caminhao");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Modelo).IsRequired().HasMaxLength(2);
            builder.Property(p => p.AnoFabricacao).IsRequired().HasMaxLength(4);
            builder.Property(p => p.AnoModelo).IsRequired().HasMaxLength(4);
        }
    }
}
