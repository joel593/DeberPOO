using System;

namespace AplicacionConsola
{
    class Program
    {
        static void Main(string[] args)

        {
            if (args.Length > 0)
            {
                Console.Write(args[0]);
            }

            Console.Write("Hola, bienvenido al centro de experimentacion magna ");
            Console.WriteLine("¿Cúal es tu nombre?");
            string datosIngresados = Console.ReadLine();
            Console.WriteLine("¿Cuantos años tenes?");
            int datosIngresados3 = Console.Read();
            Console.WriteLine("¿interesante quieres saber lo que te haremos? " + datosIngresados);
            string datosIngresados2 = Console.ReadLine();

        }
     
    }
    }

