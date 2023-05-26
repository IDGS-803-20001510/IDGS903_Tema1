using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema_1.Models
{
    public class Triangulo
    {
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }
        public double x3 { get; set; }
        public double y3 { get; set; }

        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public double lado3 { get; set; }
        public string tpTriangulo { get; set; }
        public double area { get; set; }
        public double baseT { get; set; }
        public double altura { get; set; }


        public void Lado1()
        {
            double distancia = Math.Pow(this.x2 - this.x1, 2) + Math.Pow(this.y2 - this.y1, 2);
            this.lado1 = Math.Round(Math.Sqrt(distancia));
        }

        public void Lado2()
        {
            double distancia = Math.Pow(this.x3 - this.x2, 2) + Math.Pow(this.y3 - this.y2, 2);
            this.lado2 = Math.Round(Math.Sqrt(distancia));
        }

        public void Lado3()
        {
            double distancia = Math.Pow(this.x3 - this.x1, 2) + Math.Pow(this.y3 - this.y1, 2);
            this.lado3 = Math.Round(Math.Sqrt(distancia));
        }


        public void CalcularTriangulo()
        {
            tpTriangulo = "";
            Lado1();
            Lado2();
            Lado3();

            if (this.lado1 < this.lado2 + this.lado3 && this.lado2 < this.lado1 + this.lado3 && this.lado3 < this.lado1 + this.lado2)
            {
                if (this.lado1 == this.lado2 && this.lado2 == this.lado3)
                {
                    tpTriangulo = "Equilátero";
                    area = (lado1 * lado1 * Math.Sqrt(3)) / 4;
                }
                else if (this.lado1 == this.lado2 || this.lado1 == this.lado3 || this.lado2 == this.lado3)
                {
                    tpTriangulo = "Isósceles";
                    baseT = lado1;
                    altura = Math.Sqrt(Math.Pow(lado2, 2) - Math.Pow(baseT/2,2));
                    area = (baseT * altura) / 2;
                    
                }
                else
                {
                    tpTriangulo = "Escaleno";
                    double semiP = (lado1 + lado2 + lado3) / 2;
                    area = Math.Sqrt(semiP*(semiP-lado1) * (semiP-lado2) * (semiP-lado3));
                }
            }
            else
            {
                tpTriangulo = "No es un triángulo";
            }
        }
    }
}