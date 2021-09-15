using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace K19.Models
{
    public class Aluno
    {
        [HiddenInput(DisplayValue = false)]
        public int AlunoID { get; set; }
        [Display(Name = "Nome Aluno")]
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}