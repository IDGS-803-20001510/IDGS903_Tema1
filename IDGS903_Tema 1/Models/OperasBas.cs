using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema_1.Models
{
    public class OperasBas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public int Res { get; set; }   

        public string opcion { get; set; }

        public void Sumar()
        {
            this.Res = this.Num1 + this.Num2;
        }

        public void Restar()
        {
            this.Res = this.Num1 - this.Num2;
        }

        public void Multiplicar()
        {
            this.Res = this.Num1 * this.Num2;
        }

        public void Dividir()
        {
            this.Res = this.Num1 / this.Num2;
        }

        public void Resultado()
        {
            if (opcion == "suma")
            {
                Sumar();
            }
            else if (opcion == "resta")
            {
                Restar();
            }
            else if (opcion == "multiplicacion")
            {
                Multiplicar(); 
            }
            else if (opcion == "division")
            {
                Dividir();
            }
        }
    }
}