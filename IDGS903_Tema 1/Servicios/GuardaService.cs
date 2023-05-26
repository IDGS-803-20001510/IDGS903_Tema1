using IDGS903_Tema_1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_Tema_1.Servicios
{
    public class GuardaService
    {
        public void GuardarActivo(Maestros maes)
        {
            var mt = maes.Matricula;
            var nom = maes.Nombre;
            var apa = maes.Apaterno;
            var ama = maes.Amaterno;
            var email = maes.Email;
            var datos = mt + "," + nom + "," + apa + "," + ama + "," + email + Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            File.AppendAllText(archivo, datos);
        }
    }
}