using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using IDEIBiblio.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace IDEIBiblio.DAL
{
    public class IDEIBiblioEntities : DbContext
    {

        //Ligação com a base de dados
        //Caso não tivesse sequencia de ligação seria o nome da class
        public IDEIBiblioEntities() : base("IDEIBiblio") { }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<TipoProduto> TiposProdutos { get; set; }

        //Retirar o plural das tabelas
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
