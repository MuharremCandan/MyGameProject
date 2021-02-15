using AllProjectOfEnginHocaCamp.Abstract;
using AllProjectOfEnginHocaCamp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllProjectOfEnginHocaCamp.Concrete
{
    class CampaignManger : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" has added to your account! ");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" has removed from your account !");
        }

       
    }
}
