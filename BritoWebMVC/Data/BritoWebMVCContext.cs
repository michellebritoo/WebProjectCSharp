using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BritoWebMVC.Models;

namespace BritoWebMVC.Data
{
    public class BritoWebMVCContext : DbContext
    {
        public BritoWebMVCContext (DbContextOptions<BritoWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SallesRecord> SallesRecord { get; set; }
    }
}
