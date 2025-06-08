using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppMVC.Models;

namespace AppMVC.Data
{
    public class AppMVCContext : DbContext
    {
        public AppMVCContext (DbContextOptions<AppMVCContext> options)
            : base(options)
        {
        }

        public DbSet<AppMVC.Models.UsuarioModel> UsuarioModel { get; set; } = default!;
    }
}
