using System.Collections;
public class Bank
{
    private static Hashtable accounts=new Hashtable();
    private Bank(){ }
    public static long CreateAccount()
    {
        BankAccount newAcc = new BankAccount();
        long accNo = newAcc.Number();
        accounts[accNo] = newAcc;
        return accNo;
    }
    public static long CreateAccount(AccountType aType, decimal aBal)
    {
        BankAccount newAcc = new BankAccount();
        long accNo = newAcc.Number();
        accounts[accNo] = newAcc;
        return accNo;
    }
    public static long CreateAccount(AccountType aType)
    {
        BankAccount newAcc = new BankAccount();
        long accNo = newAcc.Number();
        accounts[accNo] = newAcc;
        return accNo;
    }
    public static long CreateAccount(decimal aBal)
    {
        BankAccount newAcc = new BankAccount();
        long accNo = newAcc.Number();
        accounts[accNo] = newAcc;
        return accNo;
    }
    public static bool ClotheAccount(long accNo)
    {
        BankAccount clothing = (BankAccount)accounts[accNo];
        if(clothing != null)
        {
            accounts.Remove(accNo);
            clothing.Dispose();
            return true;
        }
        else
        {
            return false;
        }
    }
    public static BankAccount GetAccount(long accNo)
    {
        return (BankAccount)accounts[accNo];
    }
}
