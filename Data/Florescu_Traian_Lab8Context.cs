using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Florescu_Traian_Lab8.Models;

namespace Florescu_Traian_Lab8.Data
{
    public class Florescu_Traian_Lab8Context : DbContext
    {
        public Florescu_Traian_Lab8Context (DbContextOptions<Florescu_Traian_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Florescu_Traian_Lab8.Models.Book> Book { get; set; }

        public DbSet<Florescu_Traian_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Florescu_Traian_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
