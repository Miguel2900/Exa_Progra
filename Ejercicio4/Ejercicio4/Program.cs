using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "", cadenaCifrada = "";//cadena original y cifrada
            Cifrar(cadena, cadenaCifrada);
        }
        static void Cifrar(string cadena, string cadenaCifrada)//funcion de cifrado tipo cesar
        {
            Console.WriteLine("Ingrese el valor de posiciones a desplazar");
            int posiciones = int.Parse(Console.ReadLine());//cual sera la cantidad de posiciones para el cifrado
            Console.WriteLine("Ingrese la cadena a cifrar");
            cadena = Console.ReadLine();//cadena que sera cifrada
            foreach (var item in cadena)
            {
                int valor = item + posiciones;//nuevo valor que adquirira el caracter de la cadena
                if ((valor > 126))//si el caracter excede el limite de 126 tendra que volver al caracter 32
                    valor -=  95;//se substrae 95 para poder regresar al principio del limite, por ejemplo si se introduce un caracter "~", es decir (char)126
                                 //y se escoge una cantidad de desplazamiento de 1 el caracter cifrado sera " ", es decir (char)32
                                 //en caso de escoger un desplazamineto de 2 el caracter cifrado sera "!", es decir (char)33
                cadenaCifrada += (char)(valor);//se modifica el valor de cada caracter de la cadena conforme al numero de posiciones elegidos
            }
            Console.Clear();
            Console.WriteLine("Cadena original: {0}\nCadena cifrada: {1}", cadena, cadenaCifrada);//se despliegan ambas cadenas para comprararlas
        }
    }
}
