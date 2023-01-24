using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class CitiesSkylinesManager : IGameService
    {
        public void CampaignSell(Player player, Campaign campaign)
        {
            Console.WriteLine("Cities Skylines oyunu " + campaign.Name + " indiriminde " + player.FirstName + " " +
                player.LastName + " adlı oyuncuya " + (50 - ((campaign.DiscountRate * 50) / 100)) + " TL'ye satılmıştır.");
        }

        public void Refund(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " adlı oyuncuya para iadesi yapılmıştır.");
        }

        public void Sell(Player player)
        {
            Console.WriteLine("Cities Skylines oyunu " + player.FirstName + " " + player.LastName + " adlı oyuncuya 50 TL'ye satılmıştır");
        }
    }
}
