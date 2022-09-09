using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCDemo.Models;

namespace MVCDemo.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext (DbContextOptions<PizzaContext> options)
            : base(options)
        {
        }

        public DbSet<MVCDemo.Models.Pizza> Pizza { get; set; } = default!;
    }
}
