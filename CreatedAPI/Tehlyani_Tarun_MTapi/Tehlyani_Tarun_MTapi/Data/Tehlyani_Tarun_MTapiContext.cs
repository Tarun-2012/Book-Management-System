using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tehlyani_Tarun_MTapi.Models;

namespace Tehlyani_Tarun_MTapi.Data
{
    public class Tehlyani_Tarun_MTapiContext : DbContext
    {
        public Tehlyani_Tarun_MTapiContext (DbContextOptions<Tehlyani_Tarun_MTapiContext> options)
            : base(options)
        {
        }

        public DbSet<Tehlyani_Tarun_MTapi.Models.Book> Book { get; set; } = default!;
    }
}
