using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Desencriptar();
        }

        static void Desencriptar()
        {
            Console.WriteLine("Ingrese la cadena que desee desencriptar");
            string cadenaEncriptada = Console.ReadLine();//cadena encriptada
            Console.Clear();
            for (int i = 0; i < 94; i++)//Se intentara 94 intentos de desencriptacion, ya que eso es la cantidad de caracteres en el limite
            {
                string cadenaDesencriptada = "";//cadena en donde se guardara la posible desencriptacion
                foreach (var item in cadenaEncriptada)
                {
                    int valor = item - (i + 1);//valor de desplazamiento que quiza se realizo
                    if (valor < 32)//se valida si el valor es menor a 32
                        valor += 95;// en caso de ser menor a 32, se debe llevar al final del limite
                                    //por ejemplo si se tiene un caracter " ", es decir char(32)
                                    //y se prueba descifrar con un desplazamiento de 1, quedaria char(31)
                                    //por ende, se debe de llevar de nuevo al final del limite, el caracter "~", char (126)
                    cadenaDesencriptada += (char)valor;//Se va juntando la cadena
                }
                Console.WriteLine("Opcion con {0} desplazamientos: {1}", i + 1, cadenaDesencriptada);//se despliega la posible solucion de desencriptado
            }
        }
    }
}
