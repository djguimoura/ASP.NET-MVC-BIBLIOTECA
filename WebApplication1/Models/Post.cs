using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace K19.Models
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }
        public string Autor { get; set; }
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Texto { get; set; }

    }
}