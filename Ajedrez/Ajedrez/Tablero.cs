using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    class Tablero
    {
        private Pieza[,] Casilleros;
        public List<Movimiento> MovimientosBlancos;
        public List<Movimiento> MovimientosNegros;

        public Tablero()
        {
            Casilleros = new Pieza[8, 8];
            for (int n = 0; n < 8; n++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Casilleros[n, x] = new Piezas.Vacio();
                }
            }
            MovimientosBlancos = new List<Movimiento>();
            MovimientosNegros = new List<Movimiento>();

        }

        public Pieza[,] casilleros
        {
            get
            {
                return Casilleros;
            }
            set
            {
                Casilleros = value;
            }
        }

        public void AgregarFicha(Movimiento movimiento, Pieza pieza)
        {
            casilleros[movimiento.X, movimiento.Y].PonerFicha(this, movimiento, pieza);
            if(pieza.color == 1)
            {
            Casilleros[movimiento.X, movimiento.Y].CalcularMov(casilleros, movimiento, MovimientosNegros);

            }
            if(pieza.color == 2)
            {
                Casilleros[movimiento.X, movimiento.Y].CalcularMov(casilleros, movimiento, MovimientosBlancos);
            }
        }
        public void Limpiar()
        {
            for (int n = 0; n < 8; n++)
            {
                for (int x = 0; x < 8; x++)
                {
                    casilleros[x, n].Simbolo = casilleros[x, n].SimoboloOriginal;
                }
            }
        }
        public void CalcularMovs()
        {
            MovimientosBlancos = new List<Movimiento>();
            MovimientosNegros = new List<Movimiento>();
            for (int n = 0; n < 8; n++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Movimiento Cordenada = new Movimiento();
                    Cordenada.X = x;
                    Cordenada.Y = n;
                    if (casilleros[n,x].color == 1)
                    {
                        casilleros[x, n].CalcularMov(casilleros, Cordenada, MovimientosNegros);
                    }
                    if (casilleros[n, x].color == 2)
                    {
                        casilleros[x, n].CalcularMov(casilleros, Cordenada, MovimientosNegros);
                    }
                }
            }
        }
        public void PoneFichaAca(Movimiento mov,Pieza pieza,int color)
        {
            casilleros[mov.X, mov.Y] = pieza;
            CalcularMovs();
        }
    }
}
