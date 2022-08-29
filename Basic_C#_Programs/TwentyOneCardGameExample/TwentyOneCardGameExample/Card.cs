using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneCardGameExample
{
    public struct Card //public makes this class accessable to other parts of the program
    {       
        public Suit Suit { get; set; }//public makes this property accessable to other parts of the program
        public Face Face { get; set; }//public makes this property accessable to other parts of the program

    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
