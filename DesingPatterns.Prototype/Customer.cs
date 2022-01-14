using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Prototype
{
    class Customer : IProto<Customer>
    {
        public Customer(string firstName, string lastName, string id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id{ get; set; }

        public Customer Clone()
        {
            Customer newCustomer = new Customer(FirstName,LastName,Id);
            return newCustomer;
        }
    }
}
