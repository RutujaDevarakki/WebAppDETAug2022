using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Data
{
    public class WebAppDETAug2022Context : DbContext
    {
        public WebAppDETAug2022Context (DbContextOptions<WebAppDETAug2022Context> options)
            : base(options)
        {
        }

        public DbSet<WebAppDETAug2022.Models.Booking> Booking { get; set; } = default!;
    }
}
