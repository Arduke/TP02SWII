using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP02SWII.Models;

namespace TP02SWII
{
    public class PortoContext : DbContext
    {
        public DbSet<BL> BLs { get; set; }
        public DbSet<Container> Containers { get; set; }

        public PortoContext(DbContextOptions<PortoContext> options)
            : base(options)
        {
        }


    }
}
