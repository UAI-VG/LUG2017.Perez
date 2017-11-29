using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez.Piezas
{
    class Rey : Pieza
    {
        public Rey(int color)
        {
            this.color = color;
            if (color == 1)
            {
                Simbolo = 'R';
                SimoboloOriginal = 'R';
            }
            if (color == 2)
            {
                Simbolo = 'r';
                SimoboloOriginal = 'r';
            }
            Valor = 10;
        }
        public override void CalcularMov(Pieza[,] tablero, Movimiento movimiento, List<Movimiento> listas)
        {
            MovimientosDePieza = new List<Movimiento>();
            int n = 1;
            if (movimiento.X + n < 7 && movimiento.Y + n < 7)
            {
                Movimiento ParaLista = new Movimiento();
                if (tablero[movimiento.X + n, movimiento.Y + n] is Vacio)
                {
                    tablero[movimiento.X + n, movimiento.Y + n].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X + n;
                    ParaLista.Y = movimiento.Y + n;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);
                }
                else if (tablero[movimiento.X + n, movimiento.Y + n].color == color)
                {

                }
                else if (tablero[movimiento.X + n, movimiento.Y + n].color != color)
                {
                    tablero[movimiento.X + n, movimiento.Y + n].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X + n;
                    ParaLista.Y = movimiento.Y + n;
                    ParaLista.Peso = tablero[movimiento.X + n, movimiento.Y + n].Valor;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);
                }

            } //listo
            if (movimiento.X - n >= 0 && movimiento.Y - n >= 0)
            {
                Movimiento ParaLista = new Movimiento();
                if (tablero[movimiento.X - n, movimiento.Y - n] is Vacio)
                {
                    tablero[movimiento.X - n, movimiento.Y - n].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X - n;
                    ParaLista.Y = movimiento.Y - n;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);
                }
                else if (tablero[movimiento.X - n, movimiento.Y - n].color == color)
                {

                }
                else if (tablero[movimiento.X - n, movimiento.Y - n].color != color)
                {
                    tablero[movimiento.X - n, movimiento.Y - n].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X - n;
                    ParaLista.Y = movimiento.Y - n;
                    ParaLista.Peso = tablero[movimiento.X - n, movimiento.Y - n].Valor;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);

                }

            } //listo
            if (movimiento.X - n >= 0 && movimiento.Y + n < 7)
            {
                Movimiento ParaLista = new Movimiento();
                if (tablero[movimiento.X - n, movimiento.Y + n] is Vacio)
                {
                    tablero[movimiento.X - n, movimiento.Y + n].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X - n;
                    ParaLista.Y = movimiento.Y + n;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);
                }
                else if (tablero[movimiento.X - n, movimiento.Y + n].color == color)
                {

                }
                else if (tablero[movimiento.X - n, movimiento.Y + n].color != color)
                {
                    tablero[movimiento.X - n, movimiento.Y + n].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X - n;
                    ParaLista.Y = movimiento.Y + n;
                    ParaLista.Peso = tablero[movimiento.X - n, movimiento.Y + n].Valor;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);
                    ;
                }
            }
            if (movimiento.X + n < 7 && movimiento.Y - n >= 0)
            {
                Movimiento ParaLista = new Movimiento();
                if (tablero[movimiento.X + n, movimiento.Y - n] is Vacio)
                {
                    tablero[movimiento.X + n, movimiento.Y - n].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X + n;
                    ParaLista.Y = movimiento.Y - n;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);
                }
                else if (tablero[movimiento.X + n, movimiento.Y - n].color == color)
                {

                }
                else if (tablero[movimiento.X + n, movimiento.Y - n].color != color)
                {
                    tablero[movimiento.X + n, movimiento.Y - n].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X + n;
                    ParaLista.Y = movimiento.Y - n;
                    ParaLista.Peso = tablero[movimiento.X + n, movimiento.Y - n].Valor;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);

                }

            } //listo
            if (movimiento.X + n < 7)
            {
                Movimiento ParaLista = new Movimiento();
                if (tablero[movimiento.X + n, movimiento.Y] is Vacio)
                {
                    tablero[movimiento.X + n, movimiento.Y].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X + n;
                    ParaLista.Y = movimiento.Y;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);
                }
                else if (tablero[movimiento.X + n, movimiento.Y].color == color)
                {

                }
                else if (tablero[movimiento.X + n, movimiento.Y].color != color)
                {
                    tablero[movimiento.X + n, movimiento.Y].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X + n;
                    ParaLista.Y = movimiento.Y;
                    ParaLista.Peso = tablero[movimiento.X + n, movimiento.Y].Valor;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);

                }
            }
            if (movimiento.X - n >= 0)
            {
                Movimiento ParaLista = new Movimiento();
                if (tablero[movimiento.X - n, movimiento.Y] is Vacio)
                {
                    tablero[movimiento.X - n, movimiento.Y].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X - n;
                    ParaLista.Y = movimiento.Y;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);
                }
                else if (tablero[movimiento.X - n, movimiento.Y].color == color)
                {

                }
                else if (tablero[movimiento.X - n, movimiento.Y].color != color)
                {
                    tablero[movimiento.X - n, movimiento.Y].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X - n;
                    ParaLista.Y = movimiento.Y;
                    ParaLista.Peso = tablero[movimiento.X - n, movimiento.Y].Valor;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);


                }

            }
            if (movimiento.Y + n < 7)
            {
                Movimiento ParaLista = new Movimiento();
                if (tablero[movimiento.X, movimiento.Y + n] is Vacio)
                {
                    tablero[movimiento.X, movimiento.Y + n].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X;
                    ParaLista.Y = movimiento.Y + n;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);
                }
                else if (tablero[movimiento.X, movimiento.Y + n].color == color)
                {

                }
                else if (tablero[movimiento.X, movimiento.Y + n].color != color)
                {
                    tablero[movimiento.X, movimiento.Y + n].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X;
                    ParaLista.Y = movimiento.Y + n;
                    ParaLista.Peso = tablero[movimiento.X, movimiento.Y + n].Valor;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);

                }
            }
            if (movimiento.Y - n >= 0)
            {
                Movimiento ParaLista = new Movimiento();
                if (tablero[movimiento.X, movimiento.Y - n] is Vacio)
                {
                    tablero[movimiento.X, movimiento.Y - n].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X;
                    ParaLista.Y = movimiento.Y - n;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);
                }
                else if (tablero[movimiento.X, movimiento.Y - n].color == color)
                {

                }
                else if (tablero[movimiento.X, movimiento.Y - n].color != color)
                {
                    tablero[movimiento.X, movimiento.Y - n].Simbolo = Simbolo;
                    ParaLista.X = movimiento.X;
                    ParaLista.Y = movimiento.Y - n;
                    ParaLista.Peso = tablero[movimiento.X, movimiento.Y - n].Valor;
                    listas.Add(ParaLista);
                    MovimientosDePieza.Add(ParaLista);


                }
            }
            if (tablero[movimiento.X, movimiento.Y].color == 1)
            {
                if (movimiento.X == 7 && movimiento.Y == 4)
                {
                    Movimiento ParaLista = new Movimiento();
                    if (tablero[7, 7] is Torre)
                    {
                        tablero[7, 7].Simbolo = this.Simbolo;
                        ParaLista.X = 7;
                        ParaLista.Y = 7;
                        listas.Add(ParaLista);
                    }
                    if (tablero[0, 7] is Torre)
                    {
                        tablero[0, 7].Simbolo = Simbolo;
                        ParaLista.X = 0;
                        ParaLista.Y = 7;
                        listas.Add(ParaLista);
                    }
                }

            } // negro
            if (tablero[movimiento.X, movimiento.Y].color == 2)
            {
                if (movimiento.X == 0 && movimiento.Y == 4)
                {
                    Movimiento ParaLista = new Movimiento();
                    if (tablero[7, 0] is Torre)
                    {
                        tablero[7, 0].Simbolo = this.Simbolo;
                        ParaLista.X = 7;
                        ParaLista.Y = 0;
                        listas.Add(ParaLista);
                    }
                    if (tablero[0, 0] is Torre)
                    {
                        tablero[0, 0].Simbolo = Simbolo;
                        ParaLista.X = 0;
                        ParaLista.Y = 0;
                        listas.Add(ParaLista);
                    }
                }

            } // negro
            OrdenarMovs(MovimientosDePieza);
        }


    }
}
