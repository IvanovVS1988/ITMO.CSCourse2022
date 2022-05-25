
class BankAccount 
{
    public void populate(decimal balance)
    {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }

    public long Number()
    {
        return accNo;
    }

    public decimal Balance()
    {
        return accBal;
    }

    public string Type()
    {
        return accType.ToString();
    }

    private static long NextNumber()
    {
        return nextAccNo++;
    }
    public decimal Deposit(decimal amount)
    {
        accBal+=amount;
        return accBal;
    }

    public bool Withdraw(decimal amount)
    {
        if (accBal >= amount)
        {
            accBal -= amount;
            return true;
        }
        else return false;
    }

    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private static long nextAccNo=123;

}
