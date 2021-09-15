using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K19.Controllers
{
    public class RelogioController : Controller
    {
        // GET: Relogio
        public ActionResult Agora()
        {
            ViewBag.Agora = DateTime.Now.ToString("dd/MM/yyy hh:mm:ss");
            return View();
        }
    }
}