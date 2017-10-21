using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damas
{
    class Coordenada
    {
        private int x;
        private int y;

        public Coordenada()
        {
            Y = 10;
            X = 10;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
            
}
