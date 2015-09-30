using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_queries
{
   class Customer: ICustomer
   {
      string Name { get; set; }
      string Address { get; set; }

      public Customer(string name, string address)
      {
         Name = name;
         Address = address;
      }

      public string GetName()
      {
         return Name;
      }

      public string GetAddress()
      {
         return Address;
         //comment
      }
   }
}
