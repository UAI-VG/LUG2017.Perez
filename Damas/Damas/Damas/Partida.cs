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
       

       public Partida(string nombre1, string nombre2,Coordenada coordenada)
       {
           tablero = new Tablero(coordenada);
           jugador1 = new Jugador();
           jugador2 = new Jugador();
           jugador1.Nombre = nombre1;
           jugador2.Nombre = nombre2;
        } //CONSTRUCTOR

      
    //---------------------------------------------------------------------
       public bool Turno
        {
            get { return turno; }
            set { turno = value; }
        }
       public Jugador Jugador1
        {
            get { return jugador1;}
            
        }
       public Jugador Jugador2
        {
            get { return jugador2; }
        }
       public Tablero Tablero
        {
            get { return tablero; }
        }
    }
}
