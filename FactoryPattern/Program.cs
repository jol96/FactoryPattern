using FactoryPattern.Bank;
using FactoryPattern.Bank.Abstraction;
using FactoryPattern.Bank.Factory;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Transaction doing Bank of Ireland");
        IBank bankOfIreland = BankFactory.GetBankObject(BankType.BankOfIreland);
        bankOfIreland.ValidateCard();
        bankOfIreland.WithdrawMoney();
        bankOfIreland.CheckBalance();
        bankOfIreland.BankTransfer();
        bankOfIreland.MiniStatement();

        Console.WriteLine("\nTransaction doing Starling Bank");
        IBank StarlingBank = BankFactory.GetBankObject(BankType.StarlingBank);
        StarlingBank.ValidateCard();
        StarlingBank.WithdrawMoney();
        StarlingBank.CheckBalance();
        StarlingBank.BankTransfer();
        StarlingBank.MiniStatement();
        Console.Read();
    }
}