using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using IDEIBiblio.Models;

namespace IDEIBiblio.DAL
{
    public class SampleData : DropCreateDatabaseIfModelChanges<IDEIBiblioEntities>
    {
        protected override void Seed(IDEIBiblioEntities context)
        {

            
            var tipos = new List<TipoProduto>
            {
                new TipoProduto{ Tipo = "Livro"},
                new TipoProduto{ Tipo = "Cds"}
            };

            tipos.ForEach(tipo => context.TiposProdutos.Add(tipo));

            context.SaveChanges();

            var livros = new List<Livro>
            {
                new Livro{ Nome = "Tony Carreira", Preco = 23.50f, TipoProduto = tipos.Single(tipo => tipo.Tipo == "Livro") },
                new Livro{ Nome = "Jason Mraz", Preco = 15.50f, TipoProduto = tipos.Single(tipo => tipo.Tipo == "Livro") },
                new Livro{ Nome = "A Ilha das trevas", Preco = 15.50f, TipoProduto = tipos.Single(tipo => tipo.Tipo == "Livro") }
            };

            livros.ForEach(livro => context.Livros.Add(livro));

            context.SaveChanges();
           
        }
        

    }
}