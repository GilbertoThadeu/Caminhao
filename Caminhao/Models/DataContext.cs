using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caminhao.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Caminhao> Caminhao { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CaminhaoMap());
        }
    }
}
