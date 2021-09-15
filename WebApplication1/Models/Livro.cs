using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace K19.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        [Required(ErrorMessage ="Esse campo é obrigatório"), MaxLength(20)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public double Preco { get; set; }
        public int EditoraId { get; set; }
        public virtual Editora Editora { get; set; }
    }
}