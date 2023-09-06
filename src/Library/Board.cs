
using System;
using System.Reflection.Metadata;


namespace PII_Game_Of_Life
{

    public class Board{

        public bool[,] Tablero {get;set;}
        
        public Board(bool[,] tablero){
            this.Tablero = tablero;
        }
    }

}


       
