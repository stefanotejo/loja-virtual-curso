using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        // GET
        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult ContatoConfirmado()
        {
            string nome = HttpContext.Request.Form["nome"];
            string email = HttpContext.Request.Form["email"];
            string texto = HttpContext.Request.Form["texto"];

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Dados recebidos com sucesso.");
            sb.AppendLine("Conteúdo:");
            sb.AppendLine();
            sb.Append("Nome: ");
            sb.AppendLine(nome);
            sb.AppendLine();
            sb.Append("E-mail: ");
            sb.AppendLine(nome);
            sb.AppendLine();
            sb.Append("Texto: ");
            sb.AppendLine(nome);
            sb.AppendLine();

            return new ContentResult() { Content = sb.ToString() };
        }

        // GET
        public IActionResult Login()
        {
            return View();
        }

        // GET
        public IActionResult CadastroCliente()
        {
            return View();
        }

        // GET
        public IActionResult CarrinhoCompras()
        {
            return View();
        }
    }
}