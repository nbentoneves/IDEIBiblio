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

        [Key]
        [ForeignKey("TipoProduto")]
        public int TipoID { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }

        public TipoProduto Tipo { get; set; }

    }
}
