using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_queries
{
   public class CustomerRepository
   {
      public List<Customer> customers = new List<Customer>();

      public void Add(Customer customer)
      {
         customers.Add(customer);
      }
   }
}
