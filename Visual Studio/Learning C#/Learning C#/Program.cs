using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DesplegandoVariables
{
    class program
    {
        //Leccion 3: desplegando variables en la consola
        
        static void Main(String[] args)
        {
            int miEntero = 18;
            double miDoble = 55.55;
            string miString = "Giancarlo codifica";
            bool miBoleano = true;
            char miCaracter = 'G';


            Console.WriteLine("El valor de miEntero es {0} y el valor de miDoble es {1}", miEntero,miDoble);
            Console.WriteLine("El valor de miEntero es " + miEntero + " y el valor de miDoble es " + miDoble);
         
        }
    }
}