namespace IDEIBiblio.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using IDEIBiblio.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<IDEIBiblio.DAL.IDEIBiblioEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "IDEIBiblio.DAL.IDEIBiblioEntities";
        }

        protected override void Seed(IDEIBiblio.DAL.IDEIBiblioEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var tipos = new List<TipoProduto>
            {
                new TipoProduto{ Tipo = "Livro"},
                new TipoProduto{ Tipo = "CDs"}
            };

            tipos.ForEach(tipo => context.TiposProdutos.AddOrUpdate(t => t.Tipo, tipo));
            context.SaveChanges();

            var livros = new List<Livro>
            {
                new Livro{ Titulo = "Livro1", Descricao = "Sem Descrição", Escritor="Escritor1", Quantidade=100, Preco = 23.50f, TipoProduto = tipos.Single(tipo => tipo.Tipo == "Livro") },
                new Livro{ Titulo = "Livro2", Descricao = "Sem Descrição", Escritor="Escritor2", Quantidade=300, Preco = 40.0f, TipoProduto = tipos.Single(tipo => tipo.Tipo == "Livro") },
                new Livro{ Titulo = "Livro3", Descricao = "Sem Descrição", Escritor="Escritor3", Quantidade=400, Preco = 20.50f, TipoProduto = tipos.Single(tipo => tipo.Tipo == "Livro") },
            };

            livros.ForEach(livro => context.Livros.AddOrUpdate(l => l.Titulo, livro));
            context.SaveChanges();

            var cds = new List<CDs>
            {
                new CDs{ Artista="Artista1", Titulo="Titulo1", TipoProduto = tipos.Single(tipo => tipo.Tipo == "CDs") },
                new CDs{ Artista="Artista2", Titulo="Titulo2", TipoProduto = tipos.Single(tipo => tipo.Tipo == "CDs") },
                new CDs{ Artista="Artista3", Titulo="Titulo3", TipoProduto = tipos.Single(tipo => tipo.Tipo == "CDs") }
            };

            //Metodo Seed é executado sempre que executar update-database,
            //não é possivel simplesmente adicionar dados
            //AddOrUpdade(linha_pesquisa,substituir)
            cds.ForEach(cd => context.CDs.AddOrUpdate(c => c.Titulo, cd));
            context.SaveChanges();

        }
    }
}
