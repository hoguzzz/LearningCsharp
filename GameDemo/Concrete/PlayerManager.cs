using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class PlayerManager : IPlayerService
    {
        public void Add(Player player)
        {
            Console.WriteLine("Oyuncu sisteme üye olmuştur. Bilgileri şunlardır :" + player.FirstName + " " + player.LastName );
            Console.WriteLine(player.DateOfBirthYear + " " + player.NationalityId);
        }

        public void Remove(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " adlı oyuncu sistemden çıkarılmıştır.");
        }
    }
}
