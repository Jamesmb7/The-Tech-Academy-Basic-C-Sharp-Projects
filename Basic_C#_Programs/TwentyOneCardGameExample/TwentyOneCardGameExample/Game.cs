using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneCardGameExample
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set; }

        public abstract void Play(); //All this abstract method does states that every class inheriting this class must implement this method.
        
        public virtual void ListPlayers() //virtual method inside of an abstract class means that this method gets inherited by an inhereted class but it has the ability to overwrite it. These can be overwritten.
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
