using LibraryAPI.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Infrastructure
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //use this to configure the contex
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //use this to configure the model
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Freind> Freinds { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
