using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebListaDeCompras.Models;

namespace WebListaDeCompras.Controllers
{
    public class ListaCompraController : Controller
    {
        // GET: ListaCompra
        public ActionResult Index()
        {
            ItemCompra abacate = new ItemCompra();
            abacate.Nome = "Abacate";
            abacate.Preco = 1.5m;

            ItemCompra abacaxi = new ItemCompra();
            abacaxi.Nome = "Abacaxi";
            abacaxi.Preco = 2m;

            List<ItemCompra> listaCompras = new List<ItemCompra>();
            listaCompras.Add(abacate);
            listaCompras.Add(abacaxi);

            return View(listaCompras);
        }
    }
}