using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuotesWebApp.Models;

namespace QuotesWebApp.Data
{
    public class QuotesWebAppContext : DbContext
    {
        public QuotesWebAppContext (DbContextOptions<QuotesWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<QuotesWebApp.Models.Quotes> Quotes { get; set; }
    }
}
