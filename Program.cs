using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Programacion101_Practica0_Ejercicio_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Escribe un programa que le pida al usuario cinco números y calcule la media de estos. 
            */
            
            // SOLUCION BÁSICA CON VARIABLES.
            double n1,n2,n3,n4,n5;


            Console.WriteLine("Ingrese cinco números...");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());
            n4 = Convert.ToDouble(Console.ReadLine());
            n5 = Convert.ToDouble(Console.ReadLine());

            double Promedio()
            {
                double promedio = (n1 + n2 + n3 + n4 + n5) / 5;
                return promedio;
            }

            Console.WriteLine("El promedio de lo números ingresados es: " + Promedio());

            // SOLUCION CON UN ACUMULADOR

            double sumaacumulada;
            double promedio2;

            Console.WriteLine("Ingrese cinco números...");
            sumaacumulada = 0.0;
            sumaacumulada = Convert.ToDouble(Console.ReadLine());
            sumaacumulada = sumaacumulada + Convert.ToDouble(Console.ReadLine());
            sumaacumulada = sumaacumulada + Convert.ToDouble(Console.ReadLine());
            sumaacumulada = sumaacumulada + Convert.ToDouble(Console.ReadLine());
            sumaacumulada = sumaacumulada + Convert.ToDouble(Console.ReadLine());

            promedio2 = sumaacumulada / 5;

            Console.WriteLine("El promedio es de los 5 números ingresados es: "+promedio2);
            Console.ReadKey();        
        }
    }
}
