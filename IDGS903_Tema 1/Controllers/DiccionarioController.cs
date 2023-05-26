using IDGS903_Tema_1.Models;
using IDGS903_Tema_1.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema_1.Controllers
{
    public class DiccionarioController : Controller
    {
        // GET: Diccionario
        public ActionResult Guardar()
        {
            var op = new GuardarDiccionario();
            ViewBag.Diccionario = op.LeerPalabra();
            return View();
        }
        [HttpPost]
        public ActionResult Guardar(Diccionario dic)
        {
            var op = new GuardarDiccionario();
            op.GuardarPalabra(dic);
            return View();
        }
        public ActionResult LeerPalabra()
        {
            var palabra = new GuardarDiccionario();
            ViewBag.Diccionario = palabra.LeerPalabra();
            return View();
        }
        public ActionResult Traductor(Diccionario dic)
        {
            var palabra = new GuardarDiccionario();
            if(dic.palabra != null)
            {
                ViewBag.Diccionario = palabra.TraducirPalabra(dic);
            }
            return View();
        }
    }
}