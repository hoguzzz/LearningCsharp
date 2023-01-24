using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Remove(Player player);
    }
}
