using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace K19.Models
{
    public class Editora
    {
        public int EditoraId { get; set; }
        [Display(Name ="Editora")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}