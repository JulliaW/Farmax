using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Farmax.Models
{
    public class ProdutoModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Informe a quantidade")]
        public String Quantidade { get; set; }

        [Required(ErrorMessage = "Informe o valor")]
        public String Valor { get; set; }

        [Required(ErrorMessage = "Informe o lote")]
        public String Lote { get; set; }

        [Required(ErrorMessage = "Informe a validade")]
        public DateTime Validade { get; set; }

    }
}