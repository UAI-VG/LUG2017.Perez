using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    class Program
    {
        public static Tablero tableroDeJuego;
        public static Input Entradas;
        public static Graficador graficador;
        public static Movimiento movimiento;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Title = "Ajedrez Ejercicio 1";
            Console.ForegroundColor = ConsoleColor.White;
  
            tableroDeJuego = new Tablero();
            Entradas = new Input();
            graficador = new Graficador();
            while(true)
            {
                movimiento = new Movimiento();
                graficador.MostrarTablero(tableroDeJuego);
                movimiento = Entradas.RecibirDatosMov();
                tableroDeJuego.AgregarFicha(movimiento, Entradas.RecibirPieza());
                graficador.MostrarTablero(tableroDeJuego);
                graficador.MostrarMovsFicha(tableroDeJuego, movimiento);
                tableroDeJuego.Limpiar();
                Console.ReadKey();

            }
            
        }
    }
}
