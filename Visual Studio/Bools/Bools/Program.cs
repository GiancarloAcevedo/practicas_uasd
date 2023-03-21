using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace UsandoBooleanos
{
    class program
    {
        //Leccion 5: Usando Variables Booleanas

        static void Main(String[] args)
        {
            //signos que se pueden usar: > >= < <= == !=

            bool miBool = true;
            miBool = 6 != 5;
            Console.WriteLine(miBool);

            int losNiños = 17;
            bool sonAdultos = losNiños > 18;
            Console.WriteLine("Los niños son adultos? {0}", sonAdultos);
        }
    }
}