using CoffeeShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopDemo.Abstract
{
   public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
  
}
