using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IDEIBiblio.Models
{
    public class CDs : Produto
    {

        [Column("TituloCD")]
        public string Titulo { get; set; }
        public string Artista { get; set; }

    }
}