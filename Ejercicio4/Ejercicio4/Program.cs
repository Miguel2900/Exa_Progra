using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cifrar();
        }

        static void Cifrar()
        {
            Console.WriteLine("Ingrese el valor de posiciones a desplazar");
            int desplazamineto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cadena a cifrar");
            string cadena = Console.ReadLine();
            byte[] asciiBytes = System.Text.Encoding.ASCII.GetBytes(cadena);
            foreach (var item in asciiBytes)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
