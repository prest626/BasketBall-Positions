using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalmlyClassesss
{
    class Guards:Player
    {
        string threePointPercent = "90%";
        private string height = "6'6";
        public int tpg = 5;
        public Guards(string threePointPercent, string height, int tpg,  string Name, int Number, bool benched) : base(Name, Number, benched)
        {
            this.threePointPercent = threePointPercent;
            this.height = height;
            this.tpg = tpg;
        }
    }
}
