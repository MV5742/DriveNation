using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DriveNation.Data.Entities;

namespace DriveNation.Data
{
    public class DriveNationContext : DbContext
    {
        public DriveNationContext (DbContextOptions<DriveNationContext> options)
            : base(options)
        {
        }

        public DbSet<DriveNation.Data.Entities.Car> Car { get; set; } = default!;
    }
}
