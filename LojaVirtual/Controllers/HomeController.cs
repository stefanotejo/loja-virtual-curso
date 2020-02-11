using LojaVirtual.Models;
using LojaVirtual.Libraries.Email;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Contato contato = new Contato();

            contato.Nome = HttpContext.Request.Form["nome"];
            contato.Email = HttpContext.Request.Form["email"];
            contato.Texto = HttpContext.Request.Form["texto"];

            ContatoEmail.EnviarContatoPorEmail(contato);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Dados recebidos com sucesso.");
            sb.AppendLine("Conteúdo:");
            sb.AppendLine();
            sb.Append("Nome: ");
            sb.AppendLine(contato.Nome);
            sb.AppendLine();
            sb.Append("E-mail: ");
            sb.AppendLine(contato.Email);
            sb.AppendLine();
            sb.Append("Texto: ");
            sb.AppendLine(contato.Texto);
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