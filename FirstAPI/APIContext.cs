using FirstAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI
{
    public class APIContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public APIContext(DbContextOptions<APIContext> options)
        : base(options)
        {
        }
    }
}
