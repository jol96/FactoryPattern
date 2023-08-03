using FactoryPattern.Bank.Abstraction;
using FactoryPattern.Bank.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Bank.Factory
{
    public class BankFactory
    {
        public static IBank GetBankObject(BankType bankType)
        {
            IBank bankObject;
            switch (bankType)
            {
                case BankType.BankOfIreland:
                    bankObject = new BankOfIreland();
                    break;
                case BankType.StarlingBank:
                    bankObject = new StarlingBank();
                    break;
                // Add more cases if you have more banks.
                default:
                    throw new ArgumentException("Invalid bank type.", nameof(bankType));
            }
            return bankObject;
        }
    }
}
