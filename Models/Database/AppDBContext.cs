using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxApp.Models.Database
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base (options)
        {

        }

        public DbSet<MoviesDB> MoviesConnectionDB { get; set; }
    }
}
