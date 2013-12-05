using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDEIBiblio.Models;
using IDEIBiblio.DAL;

namespace IDEIBiblio.Controllers
{
    public class ProdutosController : Controller
    {

        IDEIBiblioEntities storeLib = new IDEIBiblioEntities();

        //
        // GET: /Produtos/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Produtos/Lista

        public ActionResult Livros()
        {

            ViewBag.Message = "Lista dos Livros";

            var livros = storeLib.Livros.ToList();

            return View(livros);
        }



    }
}
