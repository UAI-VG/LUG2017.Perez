using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    abstract class Pieza
    {
        public int color;
        public List<Movimiento> MovimientosDePieza;
        public char Simbolo;
        public char SimoboloOriginal;
        public int Valor;

        public virtual void PonerFicha(Tablero tablero, Movimiento Mov,Pieza pieza)
        {
        if(tablero.casilleros[Mov.X, Mov.Y].color == pieza.color)
        {
                Console.WriteLine("Ya tenes una pieza");
                Console.ReadKey();
        }
        if (tablero.casilleros[Mov.X, Mov.Y].color != pieza.color)
        {
                tablero.PoneFichaAca(Mov, pieza,color);
        }
        }
        public virtual void Comer(Tablero tablero)
        {

        }
        public virtual void Moverse(Tablero tablero, Movimiento mov)
        {

        }
        public virtual void CalcularMov(Pieza[,]tablero, Movimiento movimiento, List<Movimiento> listas)
        {

        }
        public virtual void OrdenarMovs(List<Movimiento> lista)
        {

            lista.Sort((a, b) => a.Peso.CompareTo(b.Peso));
            lista.Reverse();
        }
        }
    }
    

