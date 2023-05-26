using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema_1.Views.Distancia2P
{
    public class Distancia2P
    {
        public double x1 {get;set;}
        public double x2 { get;set;}
        public double y1 { get;set;}
        public double y2 { get;set;}
        public double res { get;set;}

        public void Resultado()
        {
            double distancia = Math.Pow(this.x2 - this.x1,2) + Math.Pow(this.y2 - this.y1,2);
            this.res = Math.Sqrt(distancia);
        }
    }
}