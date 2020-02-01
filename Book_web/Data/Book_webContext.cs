using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Book_web.Models;

namespace Book_web.Data
{
    public class Book_webContext : DbContext
    {
        public Book_webContext (DbContextOptions<Book_webContext> options)
            : base(options)
        {
        }

        public DbSet<Book_web.Models.Book> Book { get; set; }

        public DbSet<Book_web.Models.User> User { get; set; }
    }
}
