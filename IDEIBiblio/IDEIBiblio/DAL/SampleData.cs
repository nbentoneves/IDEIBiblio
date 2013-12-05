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
                new TipoProduto{ Tipo = "CDs"}
            };

            tipos.ForEach(tipo => context.TiposProdutos.Add(tipo));
            context.SaveChanges();

            var livros = new List<Livro>
            {
                new Livro{ Titulo = "Livro1", Descricao = "Sem Descrição", Escritor="Escritor1", Quantidade=100, Preco = 23.50f, TipoProduto = tipos.Single(tipo => tipo.Tipo == "Livro") },
                new Livro{ Titulo = "Livro2", Descricao = "Sem Descrição", Escritor="Escritor2", Quantidade=300, Preco = 40.0f, TipoProduto = tipos.Single(tipo => tipo.Tipo == "Livro") },
                new Livro{ Titulo = "Livro3", Descricao = "Sem Descrição", Escritor="Escritor3", Quantidade=400, Preco = 20.50f, TipoProduto = tipos.Single(tipo => tipo.Tipo == "Livro") },
            };

            livros.ForEach(livro => context.Livros.Add(livro));
            context.SaveChanges();

            var cds = new List<CDs>
            {
                new CDs{ Artista="Artista1", Titulo="Titulo1", TipoProduto = tipos.Single(tipo => tipo.Tipo == "CDs") },
                new CDs{ Artista="Artista2", Titulo="Titulo2", TipoProduto = tipos.Single(tipo => tipo.Tipo == "CDs") },
                new CDs{ Artista="Artista3", Titulo="Titulo3", TipoProduto = tipos.Single(tipo => tipo.Tipo == "CDs") }
            };

            cds.ForEach(cd => context.CDs.Add(cd));
            context.SaveChanges();
           
        }
        

    }
}