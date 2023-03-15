using GameProjectBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackendDemo.Abstract
{
    public interface IGameSalesService
    {
        void Sale(User user, Campaign campaign,Game game);
    }
}
