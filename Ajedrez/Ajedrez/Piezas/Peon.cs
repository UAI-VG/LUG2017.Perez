using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez.Piezas
{
    class Peon : Pieza
    {
        public Peon(int color)
        {
            this.color = color;
            if (color == 1)
            {
                Simbolo = 'P';
                SimoboloOriginal = 'P';
            }
            if (color == 2)
            {
                Simbolo = 'p';
                SimoboloOriginal = 'p';
            }
            Valor = 1;

        }
        public override void CalcularMov(Pieza[,] tablero, Movimiento movimiento, List<Movimiento> listas)
        {
            MovimientosDePieza = new List<Movimiento>();

            if (tablero[movimiento.X, movimiento.Y].color == 1)
            {

                if (movimiento.X == 6)
                {
                    for (int n = 1; n < 4; n++)
                    {
                        if (movimiento.X - n >= 0 && movimiento.Y + 1 < 8)
                        {
                            Movimiento ParaLista = new Movimiento();
                            if (tablero[movimiento.X - n, movimiento.Y + 1] is Vacio)
                            {
                                tablero[movimiento.X - n, movimiento.Y + 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X - n;
                                ParaLista.Y = movimiento.Y + 1;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);
                            }
                            else if (tablero[movimiento.X - n, movimiento.Y + 1].color == color)
                            {

                            }
                            else if (tablero[movimiento.X - n, movimiento.Y + 1].color != color)
                            {
                                tablero[movimiento.X - n, movimiento.Y + 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X - n;
                                ParaLista.Y = movimiento.Y + 1;
                                ParaLista.Peso = tablero[movimiento.X - n, movimiento.Y + 1].Valor;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);

                            }
                        }
                        if (movimiento.X - n >= 0 && movimiento.Y - 1 >= 0)
                        {
                            Movimiento ParaLista = new Movimiento();
                            if (tablero[movimiento.X - n, movimiento.Y - 1] is Vacio)
                            {
                                tablero[movimiento.X - n, movimiento.Y - 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X - n;
                                ParaLista.Y = movimiento.Y - 1;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);
                            }
                            else if (tablero[movimiento.X - n, movimiento.Y - 1].color == color)
                            {

                            }
                            else if (tablero[movimiento.X - n, movimiento.Y - 1].color != color)
                            {
                                tablero[movimiento.X - n, movimiento.Y - 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X - n;
                                ParaLista.Y = movimiento.Y - 1;
                                ParaLista.Peso = tablero[movimiento.X - n, movimiento.Y - 1].Valor;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);
                            }

                        }
                        if (n < 3)
                        {
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
                                    break;
                                }
                                else if (tablero[movimiento.X - n, movimiento.Y].color != color)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int n = 1; n < 3; n++)
                    {
                        if (movimiento.X - n >= 0 && movimiento.Y + 1 < 8)
                        {
                            Movimiento ParaLista = new Movimiento();
                            if (tablero[movimiento.X - n, movimiento.Y + 1] is Vacio)
                            {
                                tablero[movimiento.X - n, movimiento.Y + 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X - n;
                                ParaLista.Y = movimiento.Y + 1;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);
                            }
                            else if (tablero[movimiento.X - n, movimiento.Y + 1].color == color)
                            {

                            }
                            else if (tablero[movimiento.X - n, movimiento.Y + 1].color != color)
                            {
                                tablero[movimiento.X - n, movimiento.Y + 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X - n;
                                ParaLista.Y = movimiento.Y + 1;
                                ParaLista.Peso = tablero[movimiento.X - n, movimiento.Y + 1].Valor;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);
                                ;
                            }
                        }
                        if (movimiento.X - n >= 0 && movimiento.Y - 1 >= 0)
                        {
                            Movimiento ParaLista = new Movimiento();
                            if (tablero[movimiento.X - n, movimiento.Y - 1] is Vacio)
                            {
                                tablero[movimiento.X - n, movimiento.Y - 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X - n;
                                ParaLista.Y = movimiento.Y - 1;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);
                            }
                            else if (tablero[movimiento.X - n, movimiento.Y - 1].color == color)
                            {

                            }
                            else if (tablero[movimiento.X - n, movimiento.Y - 1].color != color)
                            {
                                tablero[movimiento.X - n, movimiento.Y - 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X - n;
                                ParaLista.Y = movimiento.Y - 1;
                                ParaLista.Peso = tablero[movimiento.X - n, movimiento.Y - 1].Valor;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);
                            }

                        }
                        if (n < 2)
                        {
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
                                    break;
                                }
                                else if (tablero[movimiento.X - n, movimiento.Y].color != color)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            } // negro

            if (tablero[movimiento.X, movimiento.Y].color == 2)
            {
                if (movimiento.X == 1)
                {
                    for (int n = 1; n < 4; n++)
                    {
                        if (movimiento.X + n < 8 && movimiento.Y + 1 < 8)
                        {
                            Movimiento ParaLista = new Movimiento();
                            if (tablero[movimiento.X + n, movimiento.Y + 1] is Vacio)
                            {
                                tablero[movimiento.X + n, movimiento.Y + 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X + n;
                                ParaLista.Y = movimiento.Y + 1;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);
                            }
                            else if (tablero[movimiento.X + n, movimiento.Y + 1].color == color)
                            {

                            }
                            else if (tablero[movimiento.X + n, movimiento.Y + 1].color != color)
                            {
                                tablero[movimiento.X + n, movimiento.Y + 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X + n;
                                ParaLista.Y = movimiento.Y + 1;
                                ParaLista.Peso = tablero[movimiento.X + n, movimiento.Y + 1].Valor;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);
                            }

                        }
                        if (movimiento.X + n < 8 && movimiento.Y - 1 >= 0)
                        {
                            Movimiento ParaLista = new Movimiento();
                            if (tablero[movimiento.X + n, movimiento.Y - 1] is Vacio)
                            {
                                tablero[movimiento.X + n, movimiento.Y - 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X + n;
                                ParaLista.Y = movimiento.Y - 1;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);
                            }
                            else if (tablero[movimiento.X + n, movimiento.Y - 1].color == color)
                            {

                            }
                            else if (tablero[movimiento.X + n, movimiento.Y - 1].color != color)
                            {
                                tablero[movimiento.X + n, movimiento.Y - 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X + n;
                                ParaLista.Y = movimiento.Y - 1;
                                ParaLista.Peso = tablero[movimiento.X + n, movimiento.Y - 1].Valor;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);

                            }

                        }
                        if (n < 3)
                        {
                            if (movimiento.X + n >= 0)
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
                                    break;
                                }
                                else if (tablero[movimiento.X + n, movimiento.Y].color != color)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int n = 1; n < 3; n++)
                    {
                        if (movimiento.X + n < 8 && movimiento.Y + 1 < 8)
                        {
                            Movimiento ParaLista = new Movimiento();
                            if (tablero[movimiento.X + n, movimiento.Y + 1] is Vacio)
                            {
                                tablero[movimiento.X + n, movimiento.Y + 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X + n;
                                ParaLista.Y = movimiento.Y + 1;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);
                            }
                            else if (tablero[movimiento.X + n, movimiento.Y + 1].color == color)
                            {

                            }
                            else if (tablero[movimiento.X + n, movimiento.Y + 1].color != color)
                            {
                                tablero[movimiento.X + n, movimiento.Y + 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X + n;
                                ParaLista.Y = movimiento.Y + 1;
                                ParaLista.Peso = tablero[movimiento.X + n, movimiento.Y + 1].Valor;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);
                            }

                        }
                        if (movimiento.X + n < 8 && movimiento.Y - 1 >= 0)
                        {
                            Movimiento ParaLista = new Movimiento();
                            if (tablero[movimiento.X + n, movimiento.Y - 1] is Vacio)
                            {
                                tablero[movimiento.X + n, movimiento.Y - 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X + n;
                                ParaLista.Y = movimiento.Y - 1;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);
                            }
                            else if (tablero[movimiento.X + n, movimiento.Y - 1].color == color)
                            {

                            }
                            else if (tablero[movimiento.X + n, movimiento.Y - 1].color != color)
                            {
                                tablero[movimiento.X + n, movimiento.Y - 1].Simbolo = Simbolo;
                                ParaLista.X = movimiento.X + n;
                                ParaLista.Y = movimiento.Y - 1;
                                ParaLista.Peso = tablero[movimiento.X + n, movimiento.Y - 1].Valor;
                                listas.Add(ParaLista);
                                MovimientosDePieza.Add(ParaLista);

                            }

                        }
                        if (n < 2)
                        {
                            if (movimiento.X + n >= 0)
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
                                    break;
                                }
                                else if (tablero[movimiento.X + n, movimiento.Y].color != color)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            OrdenarMovs(MovimientosDePieza);
        }
    }
}

