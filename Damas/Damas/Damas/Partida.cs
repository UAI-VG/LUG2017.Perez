using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damas
{
    class Partida
    {
        private bool turno;
        private Tablero tablero;
        private Jugador jugador1;
        private Jugador jugador2;
        private bool gano;
        public Partida(string nombre1, string nombre2, Coordenada coordenada)
        {
            jugador1 = new Jugador(nombre1);
            jugador2 = new Jugador(nombre2);
            tablero = new Tablero(this);
        } //CONSTRUCTOR


        //---------------------------------------------------------------------
        public bool Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        public Jugador Jugador1
        {
            get { return jugador1; }

        }
        public Jugador Jugador2
        {
            get { return jugador2; }
        }
        public Tablero Tablero
        {
            get { return tablero; }
        }
        public bool Gano
        {
            get { return gano; }
        }
    }
}
