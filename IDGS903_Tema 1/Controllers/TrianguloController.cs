using IDGS903_Tema_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema_1.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Triangulo(Triangulo tri)
        {
            tri.CalcularTriangulo();
            return View(tri);
        }
    }
}