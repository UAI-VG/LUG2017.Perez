using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez.Piezas
{
    class Vacio : Pieza
    {
        public Vacio()
        {
            Simbolo = '*';
            SimoboloOriginal = '*';
        }

        public override void PonerFicha(Tablero tablero, Movimiento mov, Pieza pieza)
        {
            if(pieza is Rey)
            {
                if (pieza.color == 1)
                {
                    if (TestearRey(tablero.MovimientosBlancos) == false)
                    {
                        tablero.PoneFichaAca(mov, pieza, color);
                    }
                    else
                    {
                        Console.WriteLine("Si pones la pieza perdes");
                        Console.ReadKey();
                    }
                }
                if (pieza.color == 2)
                {
                    if (TestearRey(tablero.MovimientosNegros) == false)
                    {
                        tablero.PoneFichaAca(mov, pieza, color);
                    }
                    else
                    {
                        Console.WriteLine("Si pones la pieza perdes");
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                tablero.PoneFichaAca(mov, pieza, color);
            }
            bool TestearRey(List<Movimiento> listas)
            {
                for (int n = 0; n < listas.Count; n++)
                {
                    if (listas[n].X == mov.X && listas[n].Y == mov.Y)
                    {
                        return true;
                    }

                }
                return false;
            }
        }
        
    }
}
