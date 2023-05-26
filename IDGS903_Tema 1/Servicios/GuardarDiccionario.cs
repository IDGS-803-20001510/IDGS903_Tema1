using IDGS903_Tema_1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace IDGS903_Tema_1.Servicios
{
    public class GuardarDiccionario
    {
        public void GuardarPalabra(Diccionario dic)
        {
            var ing = dic.Ingles.ToUpper();
            var esp = dic.Espanol.ToUpper();
            var datos = ing + "=" + esp + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/palabras.txt");
            File.AppendAllText(archivo, datos);
        }
        public Array LeerPalabra()
        {
            Array palabraData = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/palabras.txt");
            if (File.Exists(archivo))
            {
                palabraData = File.ReadAllLines(archivo);
            }
            return palabraData;
        }

        public string TraducirPalabra(Diccionario dic)
        {
            
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/palabras.txt");
            string palabraBuscada = "Esta palabra no se encuentra";

            if (File.Exists(archivo))
            {
                string[] lineas = File.ReadAllLines (archivo);

                foreach ( string item in lineas)
                {
                    var palabras = item.Split('=');
                    var ingles = palabras[0];
                    var espanol = palabras[1];

                    if (dic.opcion == "espanol" && string.Equals(ingles, dic.palabra, StringComparison.OrdinalIgnoreCase))
                    {
                        palabraBuscada = espanol;
                    }
                    else if (dic.opcion == "ingles" && string.Equals(espanol, dic.palabra, StringComparison.OrdinalIgnoreCase))
                    {
                        palabraBuscada = ingles;
                    }
                }
            }
            return palabraBuscada;
        }
    }
}