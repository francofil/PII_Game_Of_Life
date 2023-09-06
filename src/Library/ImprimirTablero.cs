using System;
using System.IO;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{

    public class ImprimirTablero{

        public static Board ImpTablero(Board tablero){  
        
            bool[,] b =  tablero.Tablero;

            int width = b.GetLength(0);
            int height = b.GetLength(1);

            Console.Clear();
            StringBuilder s = new StringBuilder();
            
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if(b[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            tablero = Juego.LogicaJuego(tablero);
            //=================================================
            //Invocar método para calcular siguiente generación
            //=================================================
            Thread.Sleep(300);
            return tablero;
    
        }
    }

}