using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Customer
    {
        private static int NumberOfCust;
        private readonly int customerID;
        private readonly int customerNumber;
        public string Name { get; private set; }
        public int PhNumber { get; private set; }
        public int CustomerID { get; }
        public int CustomerNumber { get; }

        public Customer(string name, int phNumber, int customerID)
        {
            Name = name;
            PhNumber = phNumber;
            CustomerID = customerID;
        }

    }
}
