using Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Configuration
{
    //A ASP.NET Core Identity(IdentityDbContext) é um sistema de associação ou Membership.
    //Ele nos permite criar, ler, atualizar e excluir contas de usuário;
    //também da suporte à confirmação de conta, autenticação, autorização, recuperação de senha, autenticação de dois fatores com o SMS.
    //Ele também suporta provedores de login externos como Microsoft, Facebook, Google etc.
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options) { }

        public DbSet<Product> Product { get; set; }
        public DbSet<CompraUsuario> CompraUsuario { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Compra> Compra { get; set; }

        public DbSet<LogSistema> LogSistema { get; set; }

        

        // Configura connection string de banco
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(GetConectionString());
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);
            base.OnModelCreating(builder);
        }

        private string GetConectionString()
        {
            string connectionPostgres = "Server=localhost;port=5432;user id = postgres; password = 1234;database=postgres;pooling = true";
            return connectionPostgres;
        }
    }
}
