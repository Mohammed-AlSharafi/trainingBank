using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customer
    {
        public int CustomerID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Customer(string fName, string lName, DateTime dob)
        {
            CustomerID = 10;
            FirstName = fName;
            LastName = lName;
            DateOfBirth = dob;
        }
    }
}
