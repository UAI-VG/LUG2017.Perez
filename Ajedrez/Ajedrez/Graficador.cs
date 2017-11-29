using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    class Graficador
    {
        public void MostrarTablero(Tablero tablero)
        {
            Console.Clear();
            Console.WriteLine("Lenguajes de Ultima Generacion Ajedrez Ejercicio:Calculo de Movimientos.");
            Console.WriteLine("Esteban Pablo Perez.");
            Console.WriteLine("----------Tablero De Juego----------");
            Console.WriteLine("Minusculas Blancas - Mayusculas Negras");
            Console.WriteLine("------------------------------------");
            for (int x = 0; x < 8; x++)
            {
                
                if (x == 0)
                {
                    Console.WriteLine("   A  B  C  D  E  F  G  H  ");
                    Console.WriteLine("  —————————————————————————");
                }
                Console.Write( x + 1 +"|");
                for (int y = 0; y < 8; y++)
                {
                    if(tablero.casilleros[x, y] != null)
                    {
                        Console.Write(" " + tablero.casilleros[x, y].Simbolo + " ");
                    }
                    if(y == 7)
                    {
                      Console.Write("|");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  —————————————————————————");

        }
        public void MostrarMovsFicha(Tablero tablero, Movimiento mov)
        {
            if(tablero.casilleros[mov.X, mov.Y].MovimientosDePieza != null)
            {
                for (int n = 0; n < tablero.casilleros[mov.X, mov.Y].MovimientosDePieza.Count; n++)
                {
                    Console.Write(tablero.casilleros[mov.X, mov.Y].MovimientosDePieza[n].X + 1);
                    if (tablero.casilleros[mov.X, mov.Y].MovimientosDePieza[n].Y + 1 == 1)
                    {
                        Console.Write("A");
                    }
                    if (tablero.casilleros[mov.X, mov.Y].MovimientosDePieza[n].Y + 1 == 2)
                    {
                        Console.Write("B");
                    }
                    if (tablero.casilleros[mov.X, mov.Y].MovimientosDePieza[n].Y + 1 == 3)
                    {
                        Console.Write("C");
                    }
                    if (tablero.casilleros[mov.X, mov.Y].MovimientosDePieza[n].Y + 1 == 4)
                    {
                        Console.Write("D");
                    }
                    if (tablero.casilleros[mov.X, mov.Y].MovimientosDePieza[n].Y + 1 == 5)
                    {
                        Console.Write("E");
                    }
                    if (tablero.casilleros[mov.X, mov.Y].MovimientosDePieza[n].Y + 1 == 6)
                    {
                        Console.Write("F");
                    }
                    if (tablero.casilleros[mov.X, mov.Y].MovimientosDePieza[n].Y + 1 == 7)
                    {
                        Console.Write("G");
                    }
                    if (tablero.casilleros[mov.X, mov.Y].MovimientosDePieza[n].Y + 1 == 8)
                    {
                        Console.Write("H");
                    }
                    Console.WriteLine(" Peso de Jugada:" + tablero.casilleros[mov.X, mov.Y].MovimientosDePieza[n].Peso);
                    
                }
            }
            
        }
    }
}
