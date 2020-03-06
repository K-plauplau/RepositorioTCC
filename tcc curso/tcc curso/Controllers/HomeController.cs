using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tcc_curso.Models;

namespace tcc_curso.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexLogado()
        {
            return View();
        }
        public ActionResult Cliente()
        {
            return View();
        }
        public ActionResult Pedidos()
        {
            return View();
        }

        public ActionResult Login()
        {
            HttpContext.Session.Abandon();
            ViewData["User"] = "Usuario Logado";
            return View();
        }



   

    }
}