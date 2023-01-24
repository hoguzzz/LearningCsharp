using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    internal class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckAge(Player player)
        {
            if (player.DateOfBirthYear <= DateTime.Now.Year - 18)
                return true;
            else
                return false;
        }
    }
}
