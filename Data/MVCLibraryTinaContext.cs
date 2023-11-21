using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCLibraryTina.Models;

namespace MVCLibraryTina.Data
{
    public class MVCLibraryTinaContext : DbContext
    {
        public MVCLibraryTinaContext (DbContextOptions<MVCLibraryTinaContext> options)
            : base(options)
        {
        }

        public DbSet<MVCLibraryTina.Models.Book> Book { get; set; } = default!;
    }
}
