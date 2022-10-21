using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FSPTask6.Models;

namespace FSPTask6.Data
{
    public class FSPTask6Context : DbContext
    {
        public FSPTask6Context (DbContextOptions<FSPTask6Context> options)
            : base(options)
        {
        }

        public DbSet<FSPTask6.Models.Passenger> Passenger { get; set; }

        public DbSet<FSPTask6.Models.Passport> Passport { get; set; }
    }
}
