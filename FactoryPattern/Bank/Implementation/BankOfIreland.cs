using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Bank.Abstraction;

namespace FactoryPattern.Bank.Implementation
{
    public class BankOfIreland : IBank
    {
        public void BankTransfer()
        {
            Console.WriteLine("BankOfIreland Bank Bank Transfer");
        }
        public void CheckBalance()
        {
            Console.WriteLine("BankOfIreland Bank Check Balanace");
        }

        public void MiniStatement()
        {
            Console.WriteLine("BankOfIreland Bank Mini Statement");
        }
        public void ValidateCard()
        {
            Console.WriteLine("BankOfIreland Bank Validate Card");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("BankOfIreland Bank Withdraw Money");
        }
    }
}
