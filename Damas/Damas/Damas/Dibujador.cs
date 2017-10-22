using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damas
{
    class Dibujador
    {

        public void Dibujar(Partida partida)
        {
                Console.WriteLine(partida.Jugador1.Nombre.ToString());
                Console.WriteLine(partida.Jugador2.Nombre.ToString());
                for (int X = 0; X < 10; X++)
                {
                Console.Write(X);
                for (int Y = 0; Y < 10; Y++)
                {

                    if (partida.Tablero.Matriz[X, Y] == null)
                    {
                        Console.Write("*");
                    }

                    if (partida.Tablero.Matriz[X, Y] != null)
                    {
                        if (partida.Tablero.Matriz[X, Y].Jugador == partida.Jugador1)
                        {
                            Console.Write("B"); // piezas blancas
                        }
                    }
                    if (partida.Tablero.Matriz[X, Y] != null)
                    {
                        if (partida.Tablero.Matriz[X, Y].Jugador == partida.Jugador2)
                        {
                            Console.Write("R"); // piezas rojas
                        }
                    }
                }
                    Console.WriteLine();

                }
                Console.ReadKey();
        }
    }
}
