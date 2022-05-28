
using System;

class CreateAccount
{
    // Test Harness
    static void Main() 
    {
        BankAccount acc1, acc2, acc3, acc4;
        acc1 = new BankAccount();
        acc2 = new BankAccount(AccountType.Deposit);
        acc3 = new BankAccount(100);
        acc4 = new BankAccount(AccountType.Deposit, 500);

        Console.WriteLine("Account info:\n");

        Write(acc1);
        Write(acc2);
        Write(acc3);
        Write(acc4);

        acc1.Deposit(1000);
        acc1.Withdraw(500);
        acc2.Deposit(700);
        acc2.Withdraw(200);
        acc3.Deposit(900);
        acc3.Withdraw(600);
        acc4.Deposit(1400);
        acc4.Withdraw(550);

        Console.WriteLine("\nAccount info after transactions:\n");
        Write(acc1);
        Write(acc2);
        Write(acc3);
        Write(acc4);
    }
      
    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}",  acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());

        foreach(BankTransaction tran in acc.Transactions())
        {
            Console.WriteLine("Transactions: ");
            Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
        }
    }
}
