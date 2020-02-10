using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Models;

namespace LojaVirtual.Controllers
{
    public class ProdutosController : Controller
    {
        /* Toda Action precisa retornar:
         * ActionResult OU
         * IActionResult
         */
        public ActionResult Visualizar()
        {
            Produto produto = GetProduto();

            return View(produto);
        }

        private Produto GetProduto()
        {
            return new Produto()
            {
                Id = 1,
                Nome = "Xbox One",
                Descricao = "Jogue em 4K",
                Valor = 2000.00
            };
        }
    }
}
