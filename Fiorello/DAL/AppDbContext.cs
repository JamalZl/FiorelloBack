using Fiorello.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
     public  DbSet<Settings> Settings { get; set; }
     public DbSet<Expert> Experts { get; set; }
     public DbSet<Profession> Professions { get; set; }
     public DbSet<Slider> Sliders { get; set; }

    }
}
