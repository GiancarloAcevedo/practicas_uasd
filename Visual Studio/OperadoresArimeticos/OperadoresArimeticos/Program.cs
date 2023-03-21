using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OperadoresArimeticos
{
    class program
    {
        //Leccion 4: Usando operadores arimeticos

        static void Main(String[] args)
        {
            // + - * / %

            int miEnt = 100 + 5;
            Console.WriteLine(miEnt);
            int miEnt2 = 100 - 5;
            Console.WriteLine(miEnt2);
            int miEnt3 = 5 * 100;
            Console.WriteLine(miEnt3);


            double miDoble = 100.0 / 7;
            Console.WriteLine(miDoble);

            double miPorciento = 100 % 10;
            Console.WriteLine(miPorciento);

            int masAvanzado = (3 + 5) * 6 + 30 / 2;
            Console.WriteLine("Esta operacion da como resultado {0}", masAvanzado);


            int miSuperInt = miEnt + miEnt2 + miEnt3 + masAvanzado;
            Console.WriteLine("El resultado es {0}", miSuperInt);


            //si mi variable ya tiene un valor, y lo quiero cambiar mas adelante, simplemente lo reasigno de la siguiente forma:

            int Valor1 = 111;
            //ahora se actualiza asi:
            Valor1 = 222;
            Console.WriteLine("El nuevo valor de mi variable 'Valor1' es: {0}", Valor1);

            //mas formas de aumentar la cantidad de una variable entera:

            int a = 99;
            int b = ++a;
            Console.WriteLine("La variable 'b' tomó la variable 'a' y le agregó un valor, y ahora el valor de a es: {0} y el valor de b es {1}", a, b);
        }
    }
}