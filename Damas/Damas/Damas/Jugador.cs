using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damas
{
    class Jugador
    {
        private string nombre;

        public Jugador(string nombre)
        {
            Nombre = nombre;
        } //Constructor

        public void Jugar(Tablero tablero, Coordenada cordenada)
        {
            
        }
        //--------------------------------------------------------------------------------
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
