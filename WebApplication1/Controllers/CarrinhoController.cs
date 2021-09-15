using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K19.Models;

namespace K19.Controllers
{
    public class CarrinhoController : Controller
    {
        K19Context ctx = new K19Context();
        // GET: Carrinho
        public ActionResult Index()
        {
            return View(this.PegarCarrinhoDaSessao());
        }
        public ActionResult Cancelar()
        {
            Session.Abandon();
            return RedirectToAction("Lista", "Produto");
        }
        public ActionResult Adicionar(int id = 0)
        {
            Produto p = ctx.Produtos.Find(id);

            if(p == null)
            {
                return HttpNotFound();
            }

            Carrinho carrinho = this.PegarCarrinhoDaSessao();
            carrinho.Produtos.Add(p);

            TempData["Mensagem"] = "Produto adicionado ao carrinho com sucesso!";

            return RedirectToAction("Lista", "Produto");
        }

        public ActionResult Remover(int idx = 0)
        {
            Carrinho carrinho = this.PegarCarrinhoDaSessao();
            carrinho.Produtos.RemoveAt(idx);

            return RedirectToAction("Index");
        }

        private Carrinho PegarCarrinhoDaSessao()
        {
            if (Session["Carrinho"] == null)
            {
                Session["Carrinho"] = new Carrinho();
            }
            return Session["Carrinho"] as Carrinho;
        }
    }
}