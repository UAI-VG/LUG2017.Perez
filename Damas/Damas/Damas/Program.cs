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
            do
            {
                FuncionalidadTurno();
                MostrarPartida(Partida, dibujador);
            } while (Partida.Gano == true);

        }

        


        //---------------------------------------------------------------------------------------------
        private static void Inicializar()
        {
            Partida = new Partida(nombre1, nombre2, coordenada);
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
        private static void FuncionalidadTurno()
        {
            if (Partida.Turno == true)
            {
                Partida.Jugador1.Jugar(Partida.Tablero, coordenada,Partida.Turno);
                Partida.Turno = false;
            }
            if (Partida.Turno == false)
            {
                Partida.Jugador2.Jugar(Partida.Tablero, coordenada, Partida.Turno);
                Partida.Turno = false;
            }
        }
        private static Coordenada TomarCordenada()
        {
            coordenada = new Coordenada();
            
            do
            {
              Console.WriteLine("Ingrese Cordenada De Seleccion de ficha X");
              coordenada.X = Int32.Parse(Console.ReadLine());
            }while(coordenada.X > 10 || coordenada.X < 0 );

            do
            {
              Console.WriteLine("Ingrese Cordenada De Seleccion de ficha Y");
              coordenada.Y = Int32.Parse(Console.ReadLine());
            }while(coordenada.Y > 10 || coordenada.Y < 0);


            return coordenada;
        }
    }
}
