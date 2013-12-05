using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IDEIBiblio.Models
{
    public abstract class Produto
    {

        [Key]
        public int ProdutoID { get; set; }

        public int TipoProdutoID { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Preço")]
        public float Preco { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Tipo Produto")]
        public virtual TipoProduto TipoProduto { get; set; }

    }
}
