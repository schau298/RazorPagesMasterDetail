using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMasterDetail.Models;

namespace RazorPagesMasterDetail.Data
{
    public class RazorPagesMasterDetailContext : DbContext
    {
        public RazorPagesMasterDetailContext (DbContextOptions<RazorPagesMasterDetailContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMasterDetail.Models.Books> Books { get; set; }
    }
}
