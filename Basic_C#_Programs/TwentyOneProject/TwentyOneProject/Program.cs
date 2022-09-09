using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino"; //allows you to set a const. to be used in later code. This will not change. If you need to reference something several times. 
            //Player newPlayer = new Player("Jesse"); Reusing constructor in player.cs line 11.
            //var newPLayer = new Player("Jesse");//Shows C# can actually find the data type itself if needed. Var makes code hard to read so be careful because it's hard to know the data type with it.


            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName); //Using the above constant as example. 
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"E:\Tech_Academy\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs\TwentyOneCardGameExample\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();

            /*Code for logging, append code is in dealer class streamwriter.
             * string text = "Here is some text.";
            File.WriteAllText(@"E:\Tech_Academy\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs\TwentyOneCardGameExample\log.txt", text);
            */

            /* DateTime Code, also used in dealer class with above streamwriter appending logs.
            DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;
            */




            /* ***Was the main method for most of the tutorial
            Deck deck = new Deck();
                        
            deck.Shuffle(3);           

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
            */

            /*Lambda function example 1
            int count = deck.Cards.Count(x => x.Face == Face.Ace); //This counts each element in the list "Cards", representing each element with "x" and it compares each element(x)'s Face value to see if it = Face.Ace.
            //the x could be anything. The "=>" symbol is unique and basically says to map what's on the left with what's on the right. 
            End of Lambda Function Example*/

            /* Lambda function example 2 - this creates a list and prints the 4 cards eventually added to that list
            List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            foreach (Card card in newList)
            {
                Console.WriteLine(card.Face);
            }
            End of lambda example 2*/

            /* Lambda function example 3
            List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

            int sum = numberList.Sum(x => x + 5); //This says "For each item(x) add 5 to each number(x). => could be read as "for each thing on the left, do what's on the right etc."
            int sum = numberList.Max(); //This would find the maximum number (biggest number(535)) of the list
            int sum = numberList.Min(); //This would find the minimum number (biggest number(535)) of the list
            int sum = numberList.Where(x => x > 20).Sum(); //This would create a new list(using Where) that takes the 3 numbers over 20 together from the above list. (535, 342, 23). 
            End of lambda function example 3*/

            //deck = Shuffle(deck: deck, times: 3); This is the same as above just a different way of coding it.
            //deck = Shuffle(deck, 3);
            //deck = Shuffle(deck, 3);   This goes right under deck.Shuffle(3); these all do similar things.




            /* Code below would select 1 card out of the deck and tell you how many of that card is left, there is a better way to do this with lambda expressions but this was a cool concept to see
            int counter = 0;
            foreach (Card card in deck.Cards)
            {
                if (card.Face == Face.Ace)
                {
                    counter++;
                }
            }
            End of this block of code!*/

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

