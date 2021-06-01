using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalmlyClassesss
{
    class Forwards:Player
    {
        string fgPercentage = "75%";
        private string height = "6'10";
        public int stealsPerGame = 5;
        public Forwards(string fgPercentage, string height, int stealsPerGame, string Name, int Number, bool benched) : base(Name, Number, benched)
        {
            this.fgPercentage = fgPercentage;
            this.height = height;
            this.stealsPerGame = stealsPerGame;
        }
    }
}
