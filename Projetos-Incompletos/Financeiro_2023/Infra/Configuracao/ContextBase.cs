﻿using Entities.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Configuracao
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions options) : base(options)
        {
        }
        public Microsoft.EntityFrameworkCore.DbSet<SistemaFinanceiro> SistemaFinanceiro { set; get; }
        public Microsoft.EntityFrameworkCore.DbSet<UsuarioSistemaFinanceiro> UsuarioSistemaFinanceiro { set; get; }
        public Microsoft.EntityFrameworkCore.DbSet<Categoria> Categoria { set; get; }
        public Microsoft.EntityFrameworkCore.DbSet<Despesa> Despesa { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);
        base.OnModelCreating(builder);
    }
    public string ObterStringConexao()
        {
            return "Data Source=NBQSP-FC693;Initial Catalog=FINANCEIRO_2023;Integrated Security=False;User ID=sa;Password=1234;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            //return "Data Source=NBQSP-FC693;Initial Catalog=FINANCEIRO_2023;Integrated Security=True"; // Evitar

        }


    }
}   

