using LojaVirtual.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class NewsletterEmail
    {
        // PK
        public int Id { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_001")]
        [EmailAddress(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_004")]
        public string Email { get; set; }
    }
}
