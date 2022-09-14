using K19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K19.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Lista()
        {
            ICollection<Post> posts = new List<Post>();

            for (int i = 0; i < 5; i++)
            {
                posts.Add(new Post
                {
                    Autor = "Autor do post " + i,
                    Categoria = "Categoria " + i,
                    Data = DateTime.Now.Subtract(TimeSpan.FromDays(i)),
                    Texto = i + " - Lorem ipsum dolor sit amet , consectetur adipiscing elit.",
                    Titulo = "Título do post " + i
                });
            }
            return View(posts);
        }
    }
}