using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IDEIBiblio.Models
{
    public class TipoProduto
    {

        [Key]
        public int TipoProdutoID { get; set; }
        
        public string Tipo { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }

    }
}
