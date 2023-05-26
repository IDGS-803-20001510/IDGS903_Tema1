using IDGS903_Tema_1.Views.Distancia2P;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema_1.Controllers
{
    public class Distancia2PController : Controller
    {
        // GET: Distancia2P
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resultado(Distancia2P dis2p)
        {
            dis2p.Resultado();
            var model = new Distancia2P();
            model.res = dis2p.res;
            return View(model);
        }
    }
}