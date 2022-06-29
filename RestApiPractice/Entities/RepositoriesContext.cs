using Microsoft.EntityFrameworkCore;
using RestApiPractice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiPractice.Entities
{
    public class RepositoriesContext : DbContext
    {
        public RepositoriesContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }

    }

}
