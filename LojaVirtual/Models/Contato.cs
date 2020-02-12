using LojaVirtual.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Contato
    {
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_001")]
        [MinLength(3, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_002")]
        [MaxLength(60, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_003")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_001")]
        [EmailAddress(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_004")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_001")]
        [MinLength(10, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_002")]
        [MaxLength(300, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_003")]
        public string Texto { get; set; }
    }
}
