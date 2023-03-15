using CoffeeShopProject.Abstract;
using CoffeeShopProject.Adapters;
using CoffeeShopProject.Concrete;
using CoffeeShopProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {FirstName="Nurseda",LastName="Diker",DateOfBirth=new DateTime(2000,01,20),NationalityId="25718465378"});
            Console.ReadLine();



        }
    }
}
