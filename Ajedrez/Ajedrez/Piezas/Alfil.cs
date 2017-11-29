using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez.Piezas
{
    class Alfil : Pieza
    {
        public Alfil(int color)
        {
            this.color = color;
            if (color == 1)
            {
                Simbolo = 'A';
                SimoboloOriginal = 'A';
            }
            if (color == 2)
            {
                Simbolo = 'a';
                SimoboloOriginal = 'a';
            }
            Valor = 3;
        }
        public override void CalcularMov(Pieza[,] tablero, Movimiento movimiento, List<Movimiento> listas)
        {
            MovimientosDePieza = new List<Movimiento>();
            for (int n = 1; n < 8; n++)
            {
                Movimiento ParaLista = new Movimiento();
                if (movimiento.X + n < 8 && movimiento.Y + n < 8)
                {
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
                        break;
                    }
                    else if (tablero[movimiento.X + n, movimiento.Y + n].color != color)
                    {
                        tablero[movimiento.X + n, movimiento.Y + n].Simbolo = Simbolo;
                        ParaLista.X = movimiento.X + n;
                        ParaLista.Y = movimiento.Y + n;
                        ParaLista.Peso = tablero[movimiento.X + n, movimiento.Y + n].Valor;
                        listas.Add(ParaLista);
                        MovimientosDePieza.Add(ParaLista);
                        break;
                    }
                }
            } //listo
            for (int n = 1; n < 8; n++)
            {
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
                        break;
                    }
                    else if (tablero[movimiento.X - n, movimiento.Y - n].color != color)
                    {
                        tablero[movimiento.X - n, movimiento.Y - n].Simbolo = Simbolo;
                        ParaLista.X = movimiento.X - n;
                        ParaLista.Y = movimiento.Y - n;
                        ParaLista.Peso = tablero[movimiento.X - n, movimiento.Y - n].Valor;
                        listas.Add(ParaLista);
                        MovimientosDePieza.Add(ParaLista);
                        break;
                    }
                }
            } //listo
            for (int n = 1; n < 8; n++)
            {
                if (movimiento.X - n >= 0 && movimiento.Y + n < 8)
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
                        break;
                    }
                    else if (tablero[movimiento.X - n, movimiento.Y + n].color != color)
                    {
                        tablero[movimiento.X - n, movimiento.Y + n].Simbolo = Simbolo;
                        ParaLista.X = movimiento.X - n;
                        ParaLista.Y = movimiento.Y + n;
                        ParaLista.Peso = tablero[movimiento.X - n, movimiento.Y + n].Valor;
                        listas.Add(ParaLista);
                        MovimientosDePieza.Add(ParaLista);
                        break;
                    }
                }
            } //listo
            for (int n = 1; n < 8; n++)
            {
                if (movimiento.X + n < 8 && movimiento.Y - n >= 0)
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
                        break;
                    }
                    else if (tablero[movimiento.X + n, movimiento.Y - n].color != color)
                    {
                        tablero[movimiento.X + n, movimiento.Y - n].Simbolo = Simbolo;
                        ParaLista.X = movimiento.X + n;
                        ParaLista.Y = movimiento.Y - n;
                        ParaLista.Peso = tablero[movimiento.X + n, movimiento.Y - n].Valor;
                        listas.Add(ParaLista);
                        MovimientosDePieza.Add(ParaLista);
                        break;
                    }
                }
            } //listo
            OrdenarMovs(MovimientosDePieza);
        }
    }
}
