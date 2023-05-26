using IDGS903_Tema_1.Models;
using IDGS903_Tema_1.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema_1.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda

        public ActionResult MuestraPulques()
        {
            var pulquesVenta = new PulqueService();
            var model = pulquesVenta.ObtenerPulques();
            return View(model);
        }

        public ActionResult MuestraPulques2()
        {
            TempData["nombres"] = "Alexis Prado";
            var pulquesVenta = new PulqueService();
            var model = pulquesVenta.ObtenerPulques();
            return View(model);
        }
        
        public ActionResult index()
        {
            var pulque1 = new Pulques()
            {
                Nombre = "PulqueMango",
                Descripcion = "Mango"
            };
            return Json(pulque1, JsonRequestBehavior.AllowGet);

            //return Content("Alexis Prado ASP NET ");
        }
       /* public RedirectResult Vista()
        {
            return Redirect("https://google.com");
        } */

        public ActionResult Vista()
        {
            var pulque1 = new Pulques()
            {
                Nombre = "PulqueMango",
                Descripcion = "Mango",
                Litros = 23,
                Caducidad = new DateTime(2023, 11, 5)
            };
            ViewBag.pulques = pulque1;
            return View();
        }

        public ActionResult Vista2()
        {
            ViewBag.saludo = "Hola Mundo";
            ViewBag.fecha = new DateTime(2023, 11, 2);
            ViewData["Nombre"] = "Alexis";

            String nombre = "";
            if (TempData.ContainsKey("nombres"))
            {
                nombre = TempData["nombres"] as string;
            }
            ViewBag.nombreNuevo = nombre;
            
            return View();
        }
    }
}