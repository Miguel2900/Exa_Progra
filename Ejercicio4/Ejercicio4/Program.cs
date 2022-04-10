using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "", cadenaCifrada = "";
            Cifrar(cadena, cadenaCifrada);
        }

        static void Cifrar(string cadena, string cadenaCifrada)
        {
            Console.WriteLine("Ingrese el valor de posiciones a desplazar");
            int desplazamineto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cadena a cifrar");
            cadena = Console.ReadLine();
            foreach (var item in cadena)
            {
                cadenaCifrada += (char)(item + desplazamineto);
            }
            Console.Clear();
            Console.WriteLine("Cadena original: {0}\nCadena cifrada: {1}", cadena, cadenaCifrada);
        }
    }
}
