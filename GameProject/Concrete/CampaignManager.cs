using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Adding " + campaign.CampaignName + " Campaign.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Deleting " + campaign.CampaignName + " Campaign.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Updating " + campaign.CampaignName + " Campaign.");
        }

    }
}
