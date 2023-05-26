using IDGS903_Tema_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema_1.Servicios
{
    public class PulqueService
    {
        public List<Pulques> ObtenerPulques()
        {
            var pulque1 = new Pulques()
            {
                Nombre = "Pulque1",
                Descripcion = "Frutos rojos",
                Litros = 25,
                Caducidad = new DateTime(2023 , 11 , 5)
            };
            var pulque2 = new Pulques()
            {
                Nombre = "Pulque2",
                Descripcion = "Mango Piña",
                Litros = 25,
                Caducidad = new DateTime(2023, 5, 15)
            };
            return new List<Pulques>() { pulque1, pulque2 };
        }
    }
}