using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;

namespace GameDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = 1;
            player1.FirstName = "Oğuz";
            player1.LastName = "Özyurt";
            player1.DateOfBirthYear = 1997;
            player1.NationalityId = 4231231312412;
            Player player2 = new Player() { Id = 2, FirstName = "Engin", LastName = "Demiroğ", DateOfBirthYear = 2006, NationalityId = 213213213231 };
            Campaign campaign1 = new Campaign() { Id = 1, Name = "Kış", DiscountRate = 40 };
            Campaign campaign2 = new Campaign() { Id = 2, Name = "Cadılar Bayramı", DiscountRate = 30 };
            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player1);

            CounterStrikeGlobalOffensiveManager counterStrikeGlobalOffensiveManager = new CounterStrikeGlobalOffensiveManager(new PlayerCheckManager());
            IGameService citiesSkylinesManager = new CitiesSkylinesManager();
            counterStrikeGlobalOffensiveManager.CampaignSell(player1,campaign2);
            citiesSkylinesManager.Sell(player1);
            counterStrikeGlobalOffensiveManager.Sell(player2);
            citiesSkylinesManager.Refund(player2);
            IGameService mountAndBladeManager = new MountAndBladeManager(new PlayerCheckManager());
            mountAndBladeManager.CampaignSell(player1,campaign1);
            mountAndBladeManager.CampaignSell(player2,campaign1);
        }
    }
}