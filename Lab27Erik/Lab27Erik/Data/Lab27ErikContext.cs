using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab27Erik.Models
{
    public class Lab27ErikContext : DbContext
    {
        public Lab27ErikContext (DbContextOptions<Lab27ErikContext> options)
            : base(options)
        {
        }

        public DbSet<Lab27Erik.Models.Product> Product { get; set; }
    }
}
