using System;
using System.IO;

namespace PII_Game_Of_Life
{

    public class LeerArchivo{

        public static Board TableroNuevo(){

            string url = "board.txt";
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];

            for (int  y=0; y<contentLines.Length;y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                    if(contentLines[y][x]=='1')
                    {
                        board[x,y]=true;
                    }
                }
            }
            Board board1 = new Board(board);
            return board1;
        }
    }

}