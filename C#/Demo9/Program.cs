using System;

namespace Demo9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("");

            BankAccount A = new BankAccount("GTU");

            A.Deposit(23456.00);
            A.Deposit(56740.00);
            A.Deposit(34568.00);
            A.Withdraw(89765.00);
            A.Withdraw(4356.00);
        }
    }
}
