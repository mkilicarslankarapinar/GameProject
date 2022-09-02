using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameSalesService
    {
        public void Sales1(Gamer gamer, Game game);
        public void Sales2(Gamer gamer, Game game, Campaign campaign);

    }
}
