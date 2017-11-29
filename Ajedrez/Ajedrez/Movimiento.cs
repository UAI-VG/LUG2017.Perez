using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    class Movimiento
    {
        public int X;
        public int Y;
        public int Peso;

        public Movimiento()
        {
            X = 0;
            Y = 0;
            Peso = 0;
        }

        public int peso
        {
            get
            {
                return Peso;
            }
        }
    }
}
