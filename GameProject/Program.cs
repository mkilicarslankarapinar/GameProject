

using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                Id = 1,
                FirstName = "KİLİC",
                LastName = "KARAPİNAR",
                BirthYear = 2000,
                IdentityNumber = 123456
            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);

            Game game = new Game()
            {
                Id = 1,
                Name = "World Of Warcraft",
                GamePrice = 142.93
            };
            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            Campaign campaign = new Campaign() { Id = 1, CampaignName = "KİLİCWOW15", DiscountRate = 15 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            GameSalesManager gameSalesManager = new GameSalesManager();
            gameSalesManager.Sales1(gamer, game);
            gameSalesManager.Sales2(gamer, game, campaign);


        }
    }
}
