using GameProjectBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackendDemo.Abstract
{
    public interface IUserCheckService
    {
        bool CheckIfRealUser(User user);
    }
}
