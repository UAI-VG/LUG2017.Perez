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

        private Coordenada tamaño;

        public Tablero(Coordenada Cordenada)
        {
            // INSTANCIA TABLERO Y SU TAMAÑO
            tamaño = Cordenada;
            matriz = new Piezas[Cordenada.X, Cordenada.Y];
            for (int X = 0; X < Cordenada.X; X++)
            {
                for (int Y = 0; Y < Cordenada.Y; Y++)
                {
                    matriz[Y, X] = null;
                }
            }
            //UBICA FICHAS DE CADA JUGADOR
            //for (int X = 0; X < Cordenada.X; X++)
            //{
            //    for (int Y = 0; Y < Cordenada.Y; Y++)
            //    {
            //        matriz[Y, X] = null;
            //    }
            //} SIN HACER.

        }

        public Coordenada Tamaño
        {
            get { return tamaño; }
        }
        public Piezas[,] Matriz
        {
            get { return matriz; }
        }
    }

}
