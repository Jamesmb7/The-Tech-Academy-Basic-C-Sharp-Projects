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

            /*Game game = new TwentyOneGame(); //TwentyOneGame can morph into a higher-order object. Meaning 21game inherits from game, which is why this works.          
            List<Game> games = new List<Game>();
            TwentyOneGame game = new TwentyOneGame();
            games.Add(game);*/ //This block of code is an example of Polymorphism. One class morphing into it's inheriting class. 

            /*TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            game.ListPlayers();
            Console.ReadLine();*/

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game = game + player;
            //// game += player; This is the exact same as game = game + player;
            //game = game - player;

            //***Struct info also in card related***
            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //Console.WriteLine(card1.Face);
            //***End of Struct***

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
        //*****ENUMS******
        //DaysOfTheWeek day = DaysOfTheWeek.Monday;
        //public enum DaysOfTheWeek
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}These are Enums and how they are created/called
        //
        /*ConsoleColor color = ConsoleColor.
         * This shows how important emums are. After that "." behind ConsoleColor will display available options.
         */
        //Card card = new Card();
        //card.Suit = Suit.Clubs; These are in the card section. 
        //int underlyingValue = Convert.ToInt32(Suit.Diamonds); this would return a 1. Enums are assigned values in order starting at 0, but you can also assign custom values by doing =5 etc at the end of the enum name. 
       //***END ENUM***

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
