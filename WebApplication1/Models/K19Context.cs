using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace K19.Models
{
    public class K19Context : DbContext
    {
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Carrinho> Carrinho { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}