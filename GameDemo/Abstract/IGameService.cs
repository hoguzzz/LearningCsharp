using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface IGameService
    {
        void Sell(Player player);
        void Refund(Player player);
        void CampaignSell(Player player,Campaign campaign);
    }
}
