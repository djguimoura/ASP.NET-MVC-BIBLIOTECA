using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace K19.Models
{
    public class Produto
    {
        [HiddenInput(DisplayValue=false)]
        public int ProdutoID { get; set; }

        [Display(Name ="Nome do produto")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Nome { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name ="Descrição do produtro")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Descricao { get; set; }

        [Display(Name ="Preço do produto")]
        [Required(ErrorMessage ="Esse campo é obrigatório")]
        //VALORES QUEBRADOS NÃO ESTÃO SENDO PERMITIDOS POR VALIDAÇÃO "The value '99999.99' is not valid for Preço do produto."
        [Range(minimum: 10.00, maximum: 99999.99, ErrorMessage = "O preço de Venda deve estar entre " + "10,00 e 99999,99.")]
        public double Preco { get; set; }
    }
}