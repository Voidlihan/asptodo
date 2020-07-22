using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using asptodo.Models;

namespace asptodo.Data
{
    public class asptodoContext : DbContext
    {
        public asptodoContext (DbContextOptions<asptodoContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<asptodo.Models.Note> Note { get; set; }
    }
}
