using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K19.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Usuario/Detalhes/5
        public ActionResult Detalhes(int id)
        {
            return View();
        }

        // GET: Usuario/create
        public ActionResult create()
        {
            return View();
        }

        // POST: Usuario/create
        [HttpPost]
        public ActionResult create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Formulario", "Autenticador");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Editar/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: Usuario/Editar/5
        [HttpPost]
        public ActionResult Editar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Deletar/5
        public ActionResult Deletar(int id)
        {
            return View();
        }

        // POST: Usuario/Deletar/5
        [HttpPost]
        public ActionResult Deletar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add Deletar logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
