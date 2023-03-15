using GameProjectBackendDemo.Abstract;
using GameProjectBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackendDemo.Concrete
{
    public class UserCheckManager : IUserCheckService
    {
        bool IUserCheckService.CheckIfRealUser(User user)
        {
            return true;
        }
    }
}
