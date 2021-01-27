using CoffeeShopDemo.Abstract;
using CoffeeShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceRefence;

namespace CoffeeShopDemo.Adapters
{
   public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId,customer.FirstName,customer.LastName,customer.DateOfBirth.Year);
          
        }
    }
}
