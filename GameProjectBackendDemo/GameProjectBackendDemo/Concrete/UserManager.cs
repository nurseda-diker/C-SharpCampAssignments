using GameProjectBackendDemo.Abstract;
using GameProjectBackendDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackendDemo.Concrete
{
    public class UserManager : IUserService
    {
        IUserCheckService userCheckService;
        public UserManager(IUserCheckService userCheckService)
        {
            this.userCheckService = userCheckService;
        }
        

        public void Delete(User user)
        {
            Console.WriteLine("Oyuncu silindi:" + user.FirstName + " " + user.LastName);
            
        }

        public void Save(User user)
        {
            if (userCheckService.CheckIfRealUser(user))
            {
                Console.WriteLine("Oyuncu kaydedildi:" + user.FirstName + " " + user.LastName);
                Console.ReadLine();
            }
            Console.WriteLine("Not a valid person");

           
        }

        public void Update(User user)
        {
            Console.WriteLine("Oyuncu güncellendi:" + user.FirstName + " " + user.LastName);
            
        }
    }
}
