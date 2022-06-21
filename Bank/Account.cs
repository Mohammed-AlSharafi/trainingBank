using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account
    {
        public int Number { get; }
        public Customer Owner { get; set; }
        public int Balance { get; set; }
        public string Currency { get; }
        public Account(Customer accountOwner, int initialBalance, string currency)
        {
            Number = 10;
            Owner = accountOwner;
            Balance = initialBalance;
            Currency = currency;
        }
        public void AccountInfo()
        {
            Console.WriteLine($"account number: {Number}, Owned By: {Owner.FirstName} {Owner.LastName}, Born in {Owner.DateOfBirth}, Containing {Balance} {Currency}");
        }
    }
}
