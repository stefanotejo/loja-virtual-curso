using LojaVirtual.Data;
using LojaVirtual.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models.Repositories
{
    public class NewsletterEmailRepository : INewsletterEmailRepository
    {
        // DEPENDÊNCIAS
        private readonly LojaVirtualContext _context;

        // CONSTRUTOR
        public NewsletterEmailRepository(LojaVirtualContext context)
        {
            _context = context;
        }

        public void CadastrarNewsletterEmail(NewsletterEmail email)
        {
            _context.NewsletterEmails.Add(email);
            _context.SaveChanges();
        }

        public IEnumerable<NewsletterEmail> BuscarTodosNewsletterEmails()
        {
            return _context.NewsletterEmails.ToList();
        }
    }
}
