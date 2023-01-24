using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class MountAndBladeManager : IGameService
    {
        private IPlayerCheckService _playerCheckService;
        public MountAndBladeManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void CampaignSell(Player player, Campaign campaign)
        {
            if (_playerCheckService.CheckAge(player))
            {
                Console.WriteLine("Mount and Blade oyunu " + campaign.Name + " indiriminde " + player.FirstName + " " + player.LastName + " adlı oyuncuya " + (160 - ((campaign.DiscountRate * 160) / 100)) + " TL'ye satılmıştır.");

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
                Console.WriteLine("Mount and Blade oyunu " + player.FirstName + " " + player.LastName + " adlı oyuncuya 160 TL'ye satılmıştır");

            }
            else
            {
                Console.WriteLine((DateTime.Now.Year - player.DateOfBirthYear) + "Yaşındasınız. Yaşınız Oyunu almak için uygun değildir.");
            }
        }
    }
}
