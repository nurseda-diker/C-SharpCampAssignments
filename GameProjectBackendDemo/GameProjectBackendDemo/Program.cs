
using GameProjectBackendDemo.Concrete;

using GameProjectBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackendDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserManager manager = new UserManager(new UserCheckManager());
            User user = new User();
            user.FirstName = "Nurseda";
            user.LastName = "Diker";
            user.DateOfBirth=new DateTime(2000,01,20);
            user.NationalityId = "1234567896";
            //manager.Save(user);

            Campaign campaign = new Campaign();
            campaign.DiscountRate = 10;
            campaign.CampaignName="Gel Al";
            campaign.DeadLine = new DateTime(2023, 03, 25);

            Game game = new Game();
            game.GameName = "Minecraft";
            game.Price = 100;

            GameSaleManager gameSale = new GameSaleManager();
            //gameSale.Sale(user, campaign, game);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            Console.ReadLine();




        }
    }
}
