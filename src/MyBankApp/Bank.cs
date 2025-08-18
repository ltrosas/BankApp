public class Bank
{
    private List<BankAccount> BankAccounts = new List<BankAccount>();

    public void AddAccount(BankAccount account)
    {
        BankAccounts.Add(account);
    }

    public void ListAccounts()
    {
        foreach (var acct in BankAccounts)
        {
            Console.WriteLine($"{acct.AccountId} | {acct.FirstName} {acct.LastName} | Balance: {acct.Balance}");
        }
    }

    public void RemoveAccount(BankAccount account)
    {
        BankAccounts.Remove(account);
    }
}
