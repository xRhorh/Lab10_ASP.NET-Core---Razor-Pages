using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Pintilii_Rares_Rp.Models;

namespace Asp_Pintilii_Rares_Rp.Data
{
    public class Asp_Pintilii_Rares_RpContext : DbContext
    {
        public Asp_Pintilii_Rares_RpContext (DbContextOptions<Asp_Pintilii_Rares_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Pintilii_Rares_Rp.Models.Movie> Movie { get; set; }
    }
}
