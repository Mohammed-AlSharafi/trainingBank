using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("mohammed","najeeb", new DateTime(1998, 12, 21));
            Account account1 = new Account(customer1, 100, "dollars");
            account1.AccountInfo();
            account1.Balance = 5000;
            account1.Owner.LastName = "AlSharafi";
            account1.AccountInfo();
            Console.ReadLine();
        }
    }
}
