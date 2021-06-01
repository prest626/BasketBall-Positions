using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalmlyClassesss
{
    class Center : Player
    {
        public int dpg = 5;
        public int bpg = 8;
        public Center(int dpg, int bpg, string Name, int Number, bool benched) : base(Name, Number, benched)
        {
            this.dpg = dpg;
            this.bpg = bpg;
        }
    }
}