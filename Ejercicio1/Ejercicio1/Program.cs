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
            decimal proporcion = (decimal.Parse(Console.ReadLine()) / 100) * (ancho * largo);//Operacion para obtener cuantas celdas deberian ser paredes
            int count = 1;//varaible que servira para crear el numero correcto de paredes
            for (int i = 0; i < ancho * largo; i++)
            {
                Random random = new Random();
                char valor = ' ';
                if (i < largo || i >= (ancho * largo) - largo || i % largo == 0 || i % largo == largo -1)//valida si es alguno de los extremos del laberinto
                {
                    if(i != largo && i != (ancho * largo) - 1 - largo)//representa a la entrada y salida, haciendo que nunca esten cerradas
                        valor = '█';
                }
                else if (random.Next(3) == 1 && count < proporcion)
                {
                    valor = '█';
                    count++;
                }
                Console.Write(valor);
                if ((i)%largo ==largo -1)
                    Console.Write("\n");
            }
            Console.WriteLine("Se hciieron {0} a comparacion de {1}",count,proporcion);
        }
    }
}
