using GameProjectBackendDemo.Abstract;
using GameProjectBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackendDemo.Concrete
{
    public class GameSaleManager : IGameSalesService
    {
        public void Sale(User user, Campaign campaign, Game game)
        {
            float price = (game.Price) - ((game.Price * campaign.DiscountRate) / 100);
            Console.WriteLine("Oyun " + user.FirstName + " " + user.LastName + " kullanıcısına " +  " % " + campaign.DiscountRate +
                " indirim oranı ile " + price + " fiyatına satıldı.");
            
        }
    }
}
