using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tivadar_Ana_Maria_Lab8.Models;

namespace Tivadar_Ana_Maria_Lab8.Data
{
    public class Tivadar_Ana_Maria_Lab8Context : DbContext
    {
        public Tivadar_Ana_Maria_Lab8Context (DbContextOptions<Tivadar_Ana_Maria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Tivadar_Ana_Maria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Tivadar_Ana_Maria_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Tivadar_Ana_Maria_Lab8.Models.Category> Category { get; set; }
    }
}
