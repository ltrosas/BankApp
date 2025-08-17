using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class BankAccount
{
    public Guid AccountId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Address { get; set; }
    public decimal Balance { get; private set; }

    public BankAccount(string firstName, string lastName, string address)
    {
        AccountId = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Balance = 0;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException("Deposit amounts must be positive");
        }

        this.Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > this.Balance)
        {
            throw new InvalidOperationException("Overdraft not allowed");
        }

        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException("Withdraw amounts must be positive");
        }

        this.Balance -= amount;

    }

    public void TransferTo(BankAccount targetAccount, decimal amount)
    {

        if (targetAccount == null)
        {
            throw new ArgumentNullException("Target account does not exist");
        }


        this.Withdraw(amount);
        targetAccount.Deposit(amount);
    }

}