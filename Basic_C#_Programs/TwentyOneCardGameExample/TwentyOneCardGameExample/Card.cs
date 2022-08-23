using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneCardGameExample
{
    public class Card //public makes this class accessable to other parts of the program
    {
        //public Card()
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}
        public string Suit { get; set; }//public makes this property accessable to other parts of the program
        public string Face { get; set; }//public makes this property accessable to other parts of the program

    }
}
