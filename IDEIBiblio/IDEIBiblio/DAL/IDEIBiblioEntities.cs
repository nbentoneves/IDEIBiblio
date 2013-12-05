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

        public DbSet<CDs> CDs { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoProduto> TiposProdutos { get; set; }

        //EFs fluent API
        //http://msdn.microsoft.com/en-us/data/jj591617
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Retirar o plural das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
