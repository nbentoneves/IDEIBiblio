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
                new Livro{ Titulo = "Livro1", Descricao = "Sem Descrição", Escritor="Escritor1", Quantidade=100, Preco = 23.50f, TipoProduto = tipos.Single(tipo => tipo.Tipo == "Livro") },
                new Livro{ Titulo = "Livro2", Descricao = "Sem Descrição", Escritor="Escritor2", Quantidade=300, Preco = 40.0f, TipoProduto = tipos.Single(tipo => tipo.Tipo == "Livro") },
                new Livro{ Titulo = "Livro3", Descricao = "Sem Descrição", Escritor="Escritor3", Quantidade=400, Preco = 20.50f, TipoProduto = tipos.Single(tipo => tipo.Tipo == "Livro") },
            };

            livros.ForEach(livro => context.Produtos.Add(livro));

            var cds = new List<CDs>
            {
                new CDs{ Artista="Artista1", Titulo="Titulo1" },
                new CDs{ Artista="Artista2", Titulo="Titulo2" },
                new CDs{ Artista="Artista3", Titulo="Titulo3" }
            };

            context.SaveChanges();
           
        }
        

    }
}