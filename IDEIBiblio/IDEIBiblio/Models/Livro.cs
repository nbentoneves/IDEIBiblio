using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IDEIBiblio.Models
{
    public class Livro
    {

        [Key]
        public int LivroID { get; set; }

        public int TipoProdutoID { get; set; }

        public string Nome { get; set; }
        public string Artista { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }

        //Propriedade de navegação (virtual)
        [Display(Name = "Tipo Produto")]
        public virtual TipoProduto TipoProduto { get; set; }
        

    }
}
