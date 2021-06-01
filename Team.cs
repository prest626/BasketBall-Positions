using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalmlyClassesss
{
    class Team
    {
        private List<Player> player;
        
        
        public Team(List<Player> player)
        {
            this.player = player;
        }
        public void addPlayer(Player player)
        {
            this.player.Add(player);
        }
        public void removePlayer(Player player)
        {
            this.player.Remove(player);

        }

        public List<Player> getPlayers()
        {
            return player;
        }
        public List<Player> getStrating() => player.FindAll(x => x.benched == false);

    }
}
