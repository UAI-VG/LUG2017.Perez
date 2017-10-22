using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damas
{
    class Piezas
    {
        private Jugador jugador;


        public Piezas(Jugador JugadorQuePoneFicha)
        {
            Jugador = JugadorQuePoneFicha;
        }

        public  Jugador Jugador
        {
            get { return jugador; }
            set { jugador = value; }
        }

    }
}
