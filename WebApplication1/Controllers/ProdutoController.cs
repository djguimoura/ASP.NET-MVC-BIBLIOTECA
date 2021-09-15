using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K19.Models;
using System.Data.Entity;
using System.Net;
using System.Web.Security;

namespace K19.Controllers
{
    public class ProdutoController : Controller
    {
        private K19Context ctx = new K19Context();
        //public ActionResult Lista(double? precoMinimo, double? precoMaximo)
        //{
        //    K19Context ctx = new K19Context();
        //    var produtos = ctx.Produtos.AsEnumerable();

        //    if (precoMinimo != null && precoMaximo != null)
        //    {
        //        produtos = from p in produtos
        //                   where p.Preco >= precoMinimo & p.Preco <= precoMaximo
        //                   select p;
        //    }

        //    return View(produtos);
        //}

        public ActionResult Lista()
        {
            return View(ctx.Produtos);
        }

        // GET: Produtos/Detalhes/5
        public ActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = ctx.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }
        [Authorize]
        public ActionResult Editar(int id = 0)
        {
            Produto p = ctx.Produtos.Find(id);

            if (p == null)
            {
                return HttpNotFound();
            }
            return View(p);
        }

        [HttpPost]
        public ActionResult Editar(Produto p)
        {
            ctx.Produtos.Attach(p);
            ctx.Entry(p).State = System.Data.Entity.EntityState.Modified;

            ctx.SaveChanges();

            return RedirectToAction("Lista");
        }

        // GET: Produtoes/Deletar/5
        public ActionResult Deletar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = ctx.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produtoes/Deletar/5
        [HttpPost, ActionName("Deletar")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produto produto = ctx.Produtos.Find(id);
            ctx.Produtos.Remove(produto);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ctx.Dispose();
            }
            base.Dispose(disposing);
        }

        // GET: Produto
        [HttpGet]
        [Authorize]
        public ActionResult Cadastra()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastra([Bind(Include = "ProdutoID,Nome,Descricao,Preco")] Produto p)
        {
            /* Produto p = new Produto
             {
                 Nome = nome,
                 Descricao = descricao,
                 Preco = preco
             };*/

            //AO DEBUGAR NÃO ESTÁ ENTRANDO NO IF DO MODELSTATE MESMO COM OS VALORES INCLUÍDOS NOS CAMPOS, VERIFICAR!!
            if (ModelState.IsValid)
            {
                ctx.Produtos.Add(p);
                ctx.SaveChanges();
                TempData["Mensagem"] = "Produto cadastrado com sucesso!";
                return RedirectToAction("Lista");
            }
            else
            {
                return View("Cadastra", p);
            }

        }
    }
}