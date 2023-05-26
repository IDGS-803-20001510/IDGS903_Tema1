using IDGS903_Tema_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema_1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Ventana()
        {
            return View();
        }
        public ActionResult Calculos(string n1, string n2, string opcion)
        {
            int res = 0;
            if(opcion == "suma")
            {
                res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            }
            else if(opcion == "resta")
            {
                res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
            }
            else if(opcion == "multiplicacion")
            {
                res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
            }
            else if(opcion == "division")
            {
                res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
            }

            ViewBag.Res=Convert.ToString(res);
            return View();
        }

        public ActionResult Ventana2(OperasBas op)
        {
            op.Resultado();
            var model = new OperasBas();
            model.Res = op.Res;
            return View(model);
        }
    }
}