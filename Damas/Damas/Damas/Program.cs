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
        private static Coordenada coordenada;
        static void Main(string[] args)
        {
            TomarNombresDeJugadores();
            Inicializar();
            MostrarPartida(Partida, dibujador);
        }






        //---------------------------------------------------------------------------------------------
        private static void Inicializar()
        {
            coordenada = new Coordenada();
            coordenada.X = 10;
            coordenada.Y = 10;
            Partida = new Partida(nombre1, nombre2, coordenada);
            dibujador = new Dibujador();
        }

        private static void MostrarPartida(Partida Partida, Dibujador dibujador)
        {
            dibujador.Dibujar(Partida);
        }

        private static void TomarNombresDeJugadores()
        {
            nombre1 = Console.ReadLine();
            nombre2 = Console.ReadLine();
        }
    }
}
