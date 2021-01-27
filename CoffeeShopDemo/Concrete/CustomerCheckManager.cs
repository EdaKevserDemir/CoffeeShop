using CoffeeShopDemo.Abstract;
using CoffeeShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceRefence;

namespace CoffeeShopDemo.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
