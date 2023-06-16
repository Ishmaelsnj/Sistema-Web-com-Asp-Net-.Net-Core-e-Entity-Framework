using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models.ViewModels;
using SalesWebMVC.Models;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMVC.Data
{
    public class SalesWebMVCContext : DbContext
    {
        public SalesWebMVCContext (DbContextOptions<SalesWebMVCContext> options)
            : base(options)
        {
        }

        
        public DbSet<SalesWebMVC.Models.ViewModels.Department> Department { get; set; }
        public DbSet<SalesWebMVC.Models.ViewModels.ErrorViewModel> ErrorViewModels { get; set; }

    }
}
