using CoffeeShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using CoffeeShopDemo.Entities;


namespace CoffeeShopDemo.Abstract
{
   public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
