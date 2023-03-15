using CoffeeShopProject.Abstract;
using CoffeeShopProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopProject.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {

        bool ICustomerCheckService.CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
