using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    class Input
    {
        public int x;
        public int y = 20;
        public Movimiento RecibirDatosMov()
        {
            char letra = new char();
            Console.WriteLine("Introduzca donde quiere poner la ficha en el tablero.");
            do
            {   
                Console.Write("Introduzca Columna: ");
                letra = char.Parse(Console.ReadLine());
                if(letra == 'A' || letra == 'a')
                {
                    y = 0;
                }
                if (letra == 'B' || letra == 'b')
                {
                    y = 1;
                }
                if (letra == 'C' || letra == 'c')
                {
                    y = 2;
                }
                if (letra == 'D' || letra == 'd')
                {
                    y = 3;
                }
                if (letra == 'E' || letra == 'e')
                {
                    y = 4;
                }
                if (letra == 'F' || letra == 'f')
                {
                    y = 5;
                }
                if (letra == 'G' || letra == 'g')
                {
                    y = 6;
                }
                if (letra == 'H' || letra == 'h')
                {
                    y = 7;
                }

            } while (y < 0 || y > 8);


            do
            {
                Console.Write("Introduzca Fila: ");
                x = int.Parse(Console.ReadLine());
                x = x - 1;
            } while (x < 0 || x > 8);
            Movimiento mov = new Movimiento();
            mov.X = x;
            mov.Y = y;
            return mov;
        }
        public Pieza RecibirPieza()
        {
            Console.WriteLine("Seleccione Pieza.");
            Console.WriteLine("1-ALFIL,2-PEON,3-REY,4-REINA,5-TORRE,6-CABALLO.");
            switch (y = int.Parse(Console.ReadLine()))
            {
                default:
                    {
                        return null;
                    }
                case 1:
                    {
                        return new Piezas.Alfil(RecibirColor());
                    }
                case 2:
                    {
                        return new Piezas.Peon(RecibirColor());

                    }
                case 3:
                    {
                        return new Piezas.Rey(RecibirColor());

                    }
                case 4:
                    {
                        return new Piezas.Dama(RecibirColor());

                    }
                case 5:
                    {
                        return new Piezas.Torre(RecibirColor());

                    }
                case 6:
                    {
                        return new Piezas.Caballo();
                    }
            }

        }
        public int RecibirColor()
        {
            int color = new int();
            char letra = new char();
            do
            {
                Console.WriteLine("B blancas - N negras");
                Console.Write("Color:");
                letra = char.Parse(Console.ReadLine());
                if (letra == 'N' || letra == 'n')
                {
                    color = 1;
                }
                if (letra == 'B' || letra == 'b')
                {
                    color = 2;
                }
                if (letra != 'B' && letra != 'N' && letra != 'n' && letra != 'b')
                {
                    Console.WriteLine("Error Pruebe de nuevo");
                    Console.ReadKey();
                }
            } while (letra != 'B' && letra != 'N' && letra != 'n' && letra != 'b');

            return color;
        }
    }

}
