using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace K19.Models
{
    public class Carrinho
    {
        [Key]
        public int CarrinhoID { get; set; }
        public List<Produto> Produtos { get; set; }
        public Carrinho()
        {
            this.Produtos = new List<Produto>();
        }
    }
}