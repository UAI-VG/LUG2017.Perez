using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damas
{

    class Tablero
    {
        private Piezas[,] matriz;
        public Tablero(Partida partida)
        {
            matriz = new Piezas[10, 10];
            //----------------------------------------------------------- todo null
            for (int X = 0; X < 10; X++)
            {
                for (int Y = 0; Y < 10; Y++)
                {
                    matriz[Y, X] = null;
                }
            }
            //----------------------------------------------------------- fichas Negras
            for (int X = 0; X < 10; X++)
            {
                for (int Y = 0; Y < 4; Y++)
                {
                    if (X == 0 || X == 2 || X == 4 || X == 6 || X == 8 || X == 10)
                    {
                        if (Y == 0 || Y == 2)
                        {
                            matriz[Y, X] = new Piezas(partida.Jugador1);

                        }
                    }
                    if (X == 1 || X == 3 || X == 5 || X == 7 || X == 9)
                    {
                        if (Y == 1 || Y == 3)
                        {
                            matriz[Y, X] = new Piezas(partida.Jugador1);

                        }
                    }

                }
            }
            //----------------------------------------------------------- fichas Rojas
            for (int X = 0; X < 10; X++)
            {
                for (int Y = 6; Y < 10; Y++)
                {
                    if (X == 0 || X == 2 || X == 4 || X == 6 || X == 8 || X == 10)
                    {
                        if (Y == 6 || Y == 8)
                        {
                            matriz[Y, X] = new Piezas(partida.Jugador2);

                        }
                    }
                    if (X == 1 || X == 3 || X == 5 || X == 7 || X == 9)
                    {
                        if (Y == 7 || Y == 9 )
                        {
                            matriz[Y, X] = new Piezas(partida.Jugador2);

                        }
                    }

                }
            }
        }
        public Piezas[,] Matriz
        {
            get { return matriz; }
        }


        public void CalcularFicha(Coordenada coordenada)
        {
            if(Matriz[coordenada.X, coordenada.Y] != null)
            {
               
            }
        }
    }

}
