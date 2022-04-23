using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Farmax.Models
{
    public class ClienteModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Informe o CPF")]
        public String CPF { get; set; }

        [EmailAddress(ErrorMessage = "Informe o Email")]
        public String Email { get; set; }

        public String Telefone { get; set; }

        [Required(ErrorMessage = "Informe o endereço")]
        public String Endereco { get; set; }

    }
}