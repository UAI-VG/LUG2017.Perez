using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damas
{
    class Program
    {
        private static string nombre1;
        private static string nombre2;
        private static Partida Partida;
        private static Dibujador dibujador;
        
        static void Main(string[] args)
        {
            TomarNombresDeJugadores();
            Inicializar();
            TomarCordenada();
        }


        //---------------------------------------------------------------------------------------------
        private static void Inicializar()
        {
            Partida = new Partida(nombre1, nombre2, TomarCordenada());
            dibujador = new Dibujador();
        }
        private static void MostrarPartida(Partida Partida, Dibujador dibujador)
        {
            dibujador.Dibujar(Partida);
        }
        private static void TomarNombresDeJugadores()
        {
            Console.WriteLine("ingrese nombre jugador 1");
            nombre1 = Console.ReadLine();
            Console.WriteLine("ingrese nombre jugador 2");
            nombre2 = Console.ReadLine();
        }
        private static Coordenada TomarCordenada()
        {
            Coordenada coordenada = new Coordenada();
            do
            {
                Console.WriteLine("Ingrese Cordenada De Seleccion de ficha X");
                coordenada.X = Int32.Parse(Console.ReadLine());
            } while (coordenada.X <= 10 && coordenada.X >= 0);
            do
            {
                Console.WriteLine("Ingrese Cordenada De Seleccion de ficha Y");
                coordenada.X = Int32.Parse(Console.ReadLine());
            } while (coordenada.Y <= 10 && coordenada.Y >= 0);
            return coordenada;
        }
    }
}
