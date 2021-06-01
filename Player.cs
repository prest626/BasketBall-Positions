using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalmlyClassesss
{
    public class Player : IPlayer
    {
        public readonly string Name;
        public int Number;
        public bool benched; 
        public Player(string Name, int Number, bool benched)
        {
            this.Name = Name;
            this.Number = Number;
            this.benched = benched;
        }

        public override bool Equals(object obj)
        {
            Player play = (Player)obj;
            return play.Name == Name;
            
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string Jump()
        {
            return "This player can jump high";
        }

        public string Run()
        {
            return "Player goes to get ball";
        }

        public string Score()
        {
            return "this Playerr scores";
        }

        public string Shoot()
        {
            return "This player shoots";
        }
    }
}
