using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerarLaberinto();
        }

        static void GenerarLaberinto()
        {
            Console.WriteLine("Ingrese el ancho del laberinto");
            int ancho = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el largo del laberinto");
            int largo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la proporcion de paredes del laberinto");
            decimal proporcion = (decimal.Parse(Console.ReadLine()) / 100) * (ancho * largo);
            int vacias = (ancho * largo) - (int)proporcion;
            int count = 0;
            //for (int i = 0; i < ancho; i++)
            //{
            //    for (int j = 0; j < largo; j++)
            //    {
            //        char valor = ' ';
            //        if (i == 0 || i == ancho - 1)
            //        {
            //            valor = '█';
            //        }
            //        if (i > 0 && i < ancho - 1)
            //        {
            //            Random random = new Random();
            //            if (random.Next(10) == 2 && count < proporcion)
            //            {
            //                valor = '█';
            //                count++;
            //            }
            //        }
            //        Console.Write(valor);
            //    }
            //    Console.Write("\n");
            //}
            for (int i = 0; i < ancho * largo; i++)
            {
                char valor = '█';
                if (i == largo || i == (ancho * largo) - 1 - largo || i == largo + 1 || i == (ancho * largo) - 2 - largo)
                {
                    valor = ' ';
                }
                if (i %largo != 0 || i %largo != largo - 1)
                {

                }
                Console.Write(valor);
                if ((i)%largo ==largo -1)
                    Console.Write("\n");
            }
        }
    }
}
