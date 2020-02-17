using LojaVirtual.Data;
using LojaVirtual.Models;
using LojaVirtual.Libraries.Email;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        // DEPENDÊNCIAS
        private LojaVirtualContext _context;

        // CONSTANTES
        private const string MSG_SUCESSO = "Mensagem de contato enviada com sucesso!";
        private const string MSG_SUCESSO_NEWSLETTER = "E-mail cadastrado com sucesso. Fique atento às nossas novidades!";
        private const string MSG_ERRO = "Opa! Aconteceu um erro inesperado! Tente novamente mais tarde...";

        // CONSTRUTORES
        public HomeController(LojaVirtualContext context)
        {
            _context = context;
        }

        // ACTIONS

        // GET
        public IActionResult Index()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([FromForm] NewsletterEmail newsletterEmail) // Atribui o e-mail do form automaticamente a este objeto parâmetro no submit do form
        {
            if (ModelState.IsValid)
            {
                _context.NewsletterEmails.Add(newsletterEmail);
                _context.SaveChanges();

                TempData["MSG_SUCESSO_NEWSLETTER"] = MSG_SUCESSO_NEWSLETTER;

                return RedirectToAction(nameof(Index)); // Qual a diferença? TempData funciona aqui, ViewData e ViewBag não
            }
            else
            {
                return View(); // Qual a diferença? ViewData e ViewBag são repassados aqui
            }
        }

        // GET
        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult ContatoConfirmado()
        {
            try
            {
                Contato contato = new Contato();

                contato.Nome = HttpContext.Request.Form["nome"];
                contato.Email = HttpContext.Request.Form["email"];
                contato.Texto = HttpContext.Request.Form["texto"];

                var listaMensagens = new List<ValidationResult>();
                var validationContext = new ValidationContext(contato);
                bool isValid = Validator.TryValidateObject(contato, validationContext, listaMensagens, true);

                if (isValid)
                {
                    ContatoEmail.EnviarContatoPorEmail(contato);
                    ViewData["MSG_SUCESSO"] = MSG_SUCESSO;
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Houve erros no preenchimento de um ou mais campos: <br />");

                    foreach(var mensagem in listaMensagens)
                    {
                        sb.AppendLine("- " + mensagem.ErrorMessage + "<br />");
                    }

                    ViewData["MSG_ERRO"] = sb.ToString();
                    ViewData["CONTATO"] = contato;
                }
            }
            catch(Exception)
            {
                ViewData["MSG_ERRO"] = MSG_ERRO;

                // TODO - Implementar Log
                // TODO - Especificar Exceptions
            }
            
            return View("Contato");
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