using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    public class Program
    {
 
        static void Main(string[] args)
        {
            Result();
        }

        
            public static int Rest(int ValueA, int ValueB)
        {
            return ValueA - ValueB;
        }

        public static int sum(int ValueA, int ValueB)
        {
            return ValueA + ValueB;
        }

        public static int multiply(int ValueA, int ValueB)
        {

            return (ValueA * ValueB);

        }
        public static int divi(int ValueA, int ValueB)
        {
            return (ValueA / ValueB);
        }




        public static string Saludar(string nombre, string mensaje)
        {
            return ("hola " + nombre + "." + mensaje);
        }
        public static void Result()
        {
            int ValueA = 0;
            int ValueB = 0;
            string NombreOpercaion = "";
            do
            {

           
           

            Console.WriteLine("type the first number ");
            int.TryParse(Console.ReadLine(), out ValueA);
            Console.WriteLine("type the second number");
            int.TryParse(Console.ReadLine(), out ValueB);
            Console.WriteLine("which operation you want to perform ");
            NombreOpercaion = (Console.ReadLine());

            if (NombreOpercaion == "+")
            {
                Console.WriteLine(sum(ValueA,ValueB));
            }
            else if (NombreOpercaion == "-")
            {
                Console.WriteLine(Rest(ValueA ,ValueB));
            }
            else if (NombreOpercaion == "*")
            {
                Console.WriteLine(multiply(ValueA, ValueB));
            }
            else if (NombreOpercaion == "/")
            {
                Console.WriteLine(divi(ValueA, ValueB));
            }
            else 
            {
                    Console.WriteLine("porrfavor dijite un  operador valido");
            }
            Result();

            } while (true );
        }




    }

        
      

    

}

    

