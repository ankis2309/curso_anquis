using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ConstructorBuilder(int id, string data){ }
            Console.WriteLine("hola mundo ejecucion");

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


            //var RespuestaDeFuncionInterna = FuncionInterna(5);
            var RespuestaDeFuncionInternaValida = new Program().FuncionInterna(5);
            var RespuestaDeClase1 = new Clase1();

            var RespMetodoDeClase = RespuestaDeClase1.RetornaNumeroDemostraion(1);

            Console.WriteLine(ArrayDeInts);
            Console.WriteLine("Hola Mundo Anquis");
            Console.ReadLine();
        }

        internal string FuncionInterna( int numero )
        {

            return "ejecutando la funcion interna: "+ numero;
        }

        public int FuncionPublica(int numero)
        {
            return numero;
        }


        private int FuncionPrivada(int numero)
        {
            return numero;
        }


        protected int FuncionProtegida(int numero)
        {
            return numero;
        }
    }



    public class Clase1
    {

      
        public int RetornaNumeroDemostraion(int numero)
        {
            return numero;
        }

        public string Propiedad1 { get; set; }
        public string SaludoInicial { get; set; } = "Hola";


        public string Saludo(string name){
        
            return this.SaludoInicial+" "+name;
        }
    }



    public class Clase3 : Clase1
    {

        internal int PropiedadDeClase3
        {
            get => RetornaNumeroDemostraion(1);
        }


        public string PropiedadCompuesta
        {
            get => "Numero: " + PropiedadDeClase3;
        }


    }


    public class Clase4 :Clase3
    {

        public int PropiedadDeclase4
        {
            get => PropiedadDeClase3;
        }


        public int PropiedadDeclase4_2 { get; set; }
    }


    public class Clase5
    {

        public int FuncionPublicaDeClase5(int numero)
        {

            var InstanciaDeClase4 = new Clase4();

            var MetodoDeInstanciaClase4 = InstanciaDeClase4.PropiedadDeclase4_2;
            var AccediendoAUnaPropiedadInternal = InstanciaDeClase4.PropiedadDeClase3;

            return numero*MetodoDeInstanciaClase4;
        }




    }





}
