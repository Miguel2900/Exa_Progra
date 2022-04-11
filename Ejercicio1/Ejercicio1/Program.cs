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
            Console.Clear();
            for (int i = 0; i < ancho * largo; i++)
            {
                Random random = new Random();
                char valor = ' ';//Celda vacia
                if (i < largo || i >= (ancho * largo) - largo || i % largo == 0 || i % largo == largo -1)//valida si es alguno de los extremos del laberinto
                {
                    if(i != largo && i != (ancho * largo) - 1 - largo)//representa a la entrada y salida, haciendo que nunca esten cerradas
                        valor = '█';//pared
                }
                else if (random.Next(3) == 1 && count < proporcion)//En caso de no ser un borde, se usa un random para saber si puede o no ser una pared
                {
                    valor = '█';//pared
                    count++;//se va incrementando el contador para poner solo las paredes necesarias
                }
                Console.Write(valor);//Se imprime el valor ya sea el caso
                if ((i)%largo ==largo -1)//salto de linea para que pueda ser cuadrado
                    Console.Write("\n");
            }
        }
    }
}
