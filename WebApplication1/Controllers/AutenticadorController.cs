using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K19.Models;
using System.Web.Security;

namespace K19.Controllers
{
    public class AutenticadorController : Controller
    {
        // GET: Autenticador
        public ActionResult Formulario()
        {
            return View();
        }
        public ActionResult Entrar(Usuario usuario)
        {
            if (usuario.Email != null && usuario.Senha != null && usuario.Email.Equals("gui_moura6@me.com") && usuario.Senha.Equals("K19"))
            {
                FormsAuthentication.SetAuthCookie(usuario.Email, false);
                return RedirectToAction("Lista", "Produto");
            }
            else
            {
                ViewBag.Mensagem = "Usuario ou senha incorretos";
                return View("Formulario");
            }
        }
        public ActionResult Sair()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Formulario");
        }
    }
}