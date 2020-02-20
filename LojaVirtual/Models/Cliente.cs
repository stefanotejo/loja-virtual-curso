using LojaVirtual.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Cliente
    {
        /* PK */
        public int Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_001")]
        [MinLength(3, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_002")]
        [MaxLength(60, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_003")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_001")]
        public string Cpf { get; set; }

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_001")]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_001")]
        public string Sexo { get; set; }

        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_001")]
        public string Telefone { get; set; }

        [Display(Name = "Endereço de e-mail")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_001")]
        [EmailAddress(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_004")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_001")]
        [MinLength(8, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_002")]
        [MaxLength(16, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_ERRO_003")]
        public string Senha { get; set; }
    }
}
