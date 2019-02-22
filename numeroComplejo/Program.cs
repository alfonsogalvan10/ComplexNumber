using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace numeroComplejo
{
    class Program
    {
        static void Main(string[] args)
        {
            //We´re gonna create the objects and give them values

            NumeroComplejo numero1 = new NumeroComplejo(3, 4);
            Console.WriteLine(numero1);
            NumeroComplejo numero2 = new NumeroComplejo(5);
            Console.WriteLine(numero2);

            //After have given them the values, it´s time to compare them and
            //see which one is the biggest one and show the final value of the
            //complex numbers.

            if (numero1 > numero2)
            {
                Console.WriteLine("El primer número es el mayor");
            }
            else
            {
                Console.WriteLine("El segundo número es el mayor");
            }
            Console.ReadKey();

        } /*Ending the method*/
    } /*Ending the class*/
}
