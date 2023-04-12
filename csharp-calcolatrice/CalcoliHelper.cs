using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal static class CalcoliHelper
    {

        //Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale?
        //Overload


        //Somma di due numeri interi
        public static int sum(int n1, int n2) => n1 + n2;
        //Somma di due numeri double
        public static double sum(double n1, double n2) => n1 + n2;


        //Differenza di due numeri interi
        public static int diff(int n1, int n2) => n1 - n2;
        //Differenza di due numeri double
        public static double diff(double n1, double n2) => n1 - n2;


        //Moltiplicazione di due numeri interi
        public static int mult(int n1, int n2) => n1 * n2;

        //Moltiplicazione di due numeri double
        public static double mult(double n1, double n2) => n1 * n2;

        public static int abs(this int n)
        {

           string nString = Convert.ToString(n);
            //  Console.WriteLine(nString);

            if (nString.Contains("-"))
            {
                return Convert.ToInt16(nString.Remove(0,1));
            }
            else
            {
                return n;
            }           
        }

        public static double abs(this double n)
        {

            string nString = Convert.ToString(n);
            //  Console.WriteLine(nString);

            if (nString.Contains("-"))
            {
                return Convert.ToDouble(nString.Remove(0, 1));
                
            }
            else
            {
                return n;
            }
        }

        //Minimo tra due numeri interi
        public static int min(int n1, int n2) =>n1 <= n2? n1:n2;
        //Minimo tra due numeri double
        public static double min(double n1, double n2) => n1 <= n2 ? n1 : n2;


        //Massimo tra due numeri interi
        public static int max(int n1, int n2) => n1 >= n2 ? n1 : n2;
        //Massimo tra due numeri double
        public static double max(double n1, double n2) => n1 >= n2 ? n1 : n2;

        //BONUS:

        public static double pow(this int n, int esp)
        {
            n= (n == 0 )?  1 : n;
            if (esp == 0) return 1;
            double nPow = 0;

            if (esp > 0) 
                for (int i = 1; i < esp; i++)
                    nPow += n * n;    
            else
            {
                nPow = (1.0 / n);
                for (int i =1; i < esp.abs(); i++)
                 nPow *= (1.0/n);
            }
            return nPow;
        }
    }
}
