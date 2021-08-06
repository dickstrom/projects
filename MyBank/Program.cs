using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
             var account = new BankAccount("Susans Money", 98988);
    
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} dollars.");
        }
    }
}
