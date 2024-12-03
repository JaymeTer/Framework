using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Framework.Models;

namespace Framework.Data
{
    public class FrameworkDB : DbContext
    {
        public FrameworkDB (DbContextOptions<FrameworkDB> options)
            : base(options)
        {
        }

        public DbSet<Framework.Models.Customer> Customer { get; set; } = default!;
    }
}
