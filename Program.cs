using AllProjectOfEnginHocaCamp.Concrete;
using AllProjectOfEnginHocaCamp.Entities;
using System;

namespace AllProjectOfEnginHocaCamp
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager(new UserValidationManager());
            customerManager.Add(new Customer
            {
                FirstName = "Muharrem",
                LastName = "Candan",
                DateOfBirth = 2001,
                Id = 1,
                IdentityNumber = 123123123
            });

            Customer customer = new Customer();
            customer.FirstName = "Muharrem";
            customer.LastName = "Candan";
            customer.Id = 1;
            customer.IdentityNumber = 123123123;

            Games game = new Games();
            game.Id = 1;
            game.Name = "The Last Day Of The World";
            game.Price = 125;

            Campaign campaign = new Campaign();
            campaign.CampaignId = 1;
            campaign.CampaignName = "Christmas Campaign";
            campaign.CampaignPrice = 50;

            Console.WriteLine("Dear "+customer.FirstName+" , you got  "+campaign.CampaignName +", you have %" +campaign.CampaignPrice+" discount at this game "+game.Name   );
           
            CampaignManger campaignManger = new CampaignManger();
            campaignManger.Add(campaign);

            GamesManager gamesManager = new GamesManager();
            gamesManager.Add(game);

        }
    }
}
