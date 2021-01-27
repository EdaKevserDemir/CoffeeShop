using CoffeeShopDemo.Abstract;
using CoffeeShopDemo.Adapters;
using CoffeeShopDemo.Concrete;
using CoffeeShopDemo.Entities;
using System;

namespace CoffeeShopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter);
            customerManager.Save
                (new Customer { DateOfBirth = new DateTime(1993, 3, 21), FirstName = "Eda", LastName = "Demir", NationalityId =1223115545 });

            Console.ReadLine();
        }
    }
}
