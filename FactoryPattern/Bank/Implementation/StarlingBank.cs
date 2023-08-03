using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Bank.Abstraction;

namespace FactoryPattern.Bank.Implementation
{
    public class StarlingBank : IBank
    {
        public void BankTransfer()
        {
            Console.WriteLine("StarlingBank Bank Bank Transfer");
        }
        public void CheckBalance()
        {
            Console.WriteLine("StarlingBank Bank Check Balanace");
        }
        public void MiniStatement()
        {
            Console.WriteLine("StarlingBank Bank Mini Statement");
        }
        public void ValidateCard()
        {
            Console.WriteLine("StarlingBank Bank Validate Card");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("StarlingBank Bank Withdraw Money");
        }
    }
}
