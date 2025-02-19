using eTicaret.Domain.Entities;
using ETicaret.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaret.Persistance {
    class DesignTimeDBContextFactory : IDesignTimeDbContextFactory<ETicaretDBContext> {
        public ETicaretDBContext CreateDbContext(string[] args) { 
            DbContextOptionsBuilder<ETicaretDBContext> optionsBuilder = new();
            optionsBuilder.UseNpgsql(Configurations.ConnectionString);
            return new(optionsBuilder.Options);
        }
    }
}
