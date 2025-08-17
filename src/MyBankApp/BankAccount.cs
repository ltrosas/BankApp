using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class BankAccount
{
    public Guid AccountId { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public decimal Balance { get; private set; }

    public BankAccount(string firstName, string lastName, string address)
    {
        AccountId = Guid.NewGuid();
        FirstName = firstName;
        FirstName = lastName;
        Address = address;
        Balance = 0;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new InvalidOperationException("Deposit amounts must be positive");
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
            throw new InvalidOperationException("Withdraw amounts must be positive");
        }

        this.Balance -= amount;

    }

    public void TransferTo(BankAccount targetAccount, decimal amount)
    {

        if (targetAccount == null)
        {
            throw new InvalidOperationException("Deposit account does not exist");
        }


        this.Withdraw(amount);
        targetAccount.Deposit(amount);
    }

}