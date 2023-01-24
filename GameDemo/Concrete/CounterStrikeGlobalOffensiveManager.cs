using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class CounterStrikeGlobalOffensiveManager : IGameService
    {
        private IPlayerCheckService _playerCheckService;
        public CounterStrikeGlobalOffensiveManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void CampaignSell(Player player, Campaign campaign)
        {
            if (_playerCheckService.CheckAge(player))
            {
                Console.WriteLine("Counter Strike Global Offensive oyunu " + campaign.Name + " indiriminde " + player.FirstName + " " + player.LastName + " adlı oyuncuya " + (100 - ((campaign.DiscountRate * 100)/100)) + " TL'ye satılmıştır.");

            }
            else
            {
                Console.WriteLine((DateTime.Now.Year - player.DateOfBirthYear) + "Yaşındasınız. Yaşınız Oyunu almak için uygun değildir.");
            }
        }

        public void Refund(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " adlı oyuncuya para iadesi yapılmıştır.");
        }

        public void Sell(Player player)
        {
            if (_playerCheckService.CheckAge(player))
            {
                Console.WriteLine("Counter Strike Global Offensive oyunu " + player.FirstName + " " + player.LastName + " adlı oyuncuya 100 TL'ye satılmıştır");
                
            }
            else
            {
                Console.WriteLine((DateTime.Now.Year-player.DateOfBirthYear) + "Yaşındasınız. Yaşınız Oyunu almak için uygun değildir.");
            }
        }
    }
}
