using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSalesManager : IGameSalesService
    {
        public void Sales1(Gamer gamer, Game game)
        {
            Console.WriteLine("The player named " + gamer.FirstName + " " + gamer.LastName + " the game named " + game.Name
                 + " Bought for " + game.GamePrice + " TL"
                );
        }

        public void Sales2(Gamer gamer, Game game, Campaign campaign)
        {
            double campaignPrice = Math.Round(game.GamePrice - (game.GamePrice * campaign.DiscountRate / 100), 2);
            Console.WriteLine("The player named " + gamer.FirstName + " " + gamer.LastName +  " the game named " + game.Name
                 + " Bought for " + campaignPrice +  " TL" + " with the " + campaign.CampaignName + " coupon code.");
        }
    }
}
