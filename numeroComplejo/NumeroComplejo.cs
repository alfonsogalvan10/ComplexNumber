using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroComplejo
{
    class NumeroComplejo
    {
        /// <summary>
        /// We're gonna create a program in order to make complex numbers
        /// </summary>
        /// 

        double parteReal; /*Each number has a real part...*/
        double parteImaginaria; /*... and an abstract part*/

        //Creating two constructors we´re making possible the possibility to have two
        //kind of complex numbers, with those two attributes or just with one of them.

        public NumeroComplejo(double parteReal, double parteImaginaria)
        {
            this.parteReal = parteReal;
            this.parteImaginaria = parteImaginaria;
        }

        public NumeroComplejo(int parteReal)
        {
            this.parteReal = parteReal;
            this.parteImaginaria = 0;
        }

        //Each method doesn´t have to act equally like the others, so using override we avoid that.

        public override string ToString()
        {
            if (parteImaginaria >= 0)
            {
                return parteReal + "+" + parteImaginaria + "i";
            }
            else
            {
                return parteReal + "" + parteImaginaria + "i";
            }
        }

        //Methods to calculate the value for the complex number

        public static NumeroComplejo Suma(NumeroComplejo n1, NumeroComplejo n2)
        {
            double real = n1.parteReal + n2.parteReal;
            double imag = n1.parteImaginaria + n2.parteImaginaria;

            NumeroComplejo resul = new NumeroComplejo(real, imag);
            return resul;
        }

        public NumeroComplejo Suma(NumeroComplejo n2)
        {
            double real = this.parteReal + n2.parteReal;
            double imag = this.parteImaginaria + n2.parteImaginaria;

            NumeroComplejo resul = new NumeroComplejo(real, imag);
            return resul;
        }

        public static bool operator <(NumeroComplejo n1, NumeroComplejo n2)
        {
            if (n1.parteReal < n2.parteReal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(NumeroComplejo n1, NumeroComplejo n2)
        {
            if (n1.parteReal > n2.parteReal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Help us changing the type of the data
        public static implicit operator NumeroComplejo(int dato)
        {
            NumeroComplejo n = new NumeroComplejo(dato);
            return n;
        }

    } /*Ending the class*/
}
