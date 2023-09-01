using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuoteWebApplication.Models;

namespace QuoteWebApplication.Data
{
    public class QuoteWebApplicationContext : DbContext
    {
        public QuoteWebApplicationContext (DbContextOptions<QuoteWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<QuoteWebApplication.Models.Quote> Quote { get; set; } = default!;
    }
}
