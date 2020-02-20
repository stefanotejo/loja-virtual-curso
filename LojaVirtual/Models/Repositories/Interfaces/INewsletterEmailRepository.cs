using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models.Repositories.Interfaces
{
    public interface INewsletterEmailRepository
    {
        // CRUD
        void CadastrarNewsletterEmail(NewsletterEmail email);
        IEnumerable<NewsletterEmail> BuscarTodosNewsletterEmails();
    }
}
