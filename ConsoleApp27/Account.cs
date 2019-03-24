using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Account
    {
        private static int NumberOfAcc;
        private readonly int accountNumber;
        private readonly Customer accountOwner;
        private int maxMinusAllowed;
        public int AccountNumber { get; }
        public int Balance { get; private set; }
        public Customer AccountOwner { get;}
        public int MaxMinusAllowed { get;}



    }
}
