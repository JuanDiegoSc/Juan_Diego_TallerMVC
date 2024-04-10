using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Juan_Diego_TallerMVC.Models;

namespace Juan_Diego_TallerMVC.Data
{
    public class Juan_Diego_TallerMVCContext : DbContext
    {
        public Juan_Diego_TallerMVCContext (DbContextOptions<Juan_Diego_TallerMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Juan_Diego_TallerMVC.Models.Burger> Burger { get; set; } = default!;
    }
}
