using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("hola mundo");

            bool False = false;
            string  Cadena1 = "Cadena de texo";
            int     Numero  = 0;
            bool    Boleano = False;

            string[] ArrayDeSgtrings = { "cadena 1", "cadena 2" };

            List<string> ListaDeSgtrings =  new List<string>() { "cadena 1", "cadena 2" };

            int[] ArrayDeInts = { 1, 2 };


            var ListadeNumeros = new List<int>() { 1, 2, 3,4,5 };

            foreach (var itemNumerico in ListadeNumeros)
            {
                Console.WriteLine("Numero: " + itemNumerico);
            }

            Console.WriteLine(Cadena1);
            Console.WriteLine(Numero);
            Console.WriteLine(Boleano);
            Console.WriteLine(ArrayDeSgtrings);

            foreach (var item in ArrayDeSgtrings)
            {
                Console.WriteLine(item, "items de array");
            }

            Console.WriteLine(ArrayDeInts);
            Console.WriteLine("Hola Mundo Anquis");
            Console.ReadLine();
        }


        internal int Abc(int numero)
        {
            return numero;
        }
    }
}
