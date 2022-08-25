using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneCardGameExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine(); This commented out line of code was to display inheritence. TwentyOneGame inherited from Game all of it's aspects and is useable with this code. Game = broad, twentyone = specific. 

            Deck deck = new Deck();
            deck.Shuffle(3);
            //deck = Shuffle(deck: deck, times: 3); This is the same as above just a different way of coding it.
            //deck = Shuffle(deck, 3);
            //deck = Shuffle(deck, 3);    

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

       

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
