using GameProjectBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackendDemo.Abstract
{
    public interface IUserService
    {
        void Save(User user);
        void Update(User user);
        void Delete(User user);

    }
}
