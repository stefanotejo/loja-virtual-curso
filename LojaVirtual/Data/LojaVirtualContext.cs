using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Data
{
    public class LojaVirtualContext : DbContext
    {
        /*
         * Entity Framework Core, ou EF Core -> ORM (Object-Relational Mapping)
         * ORM -> Biblioteca que mapeia objetos para tabelas relacionais (Code First)
         */
         public LojaVirtualContext(DbContextOptions<LojaVirtualContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<NewsletterEmail> NewsletterEmails { get; set; }
    }
}
