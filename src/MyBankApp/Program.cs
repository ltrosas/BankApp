var account = new BankAccount("Lucas", "Rosas", "1 Fake Street");

bool running = true;

while (running)
{
    Console.Clear();
    Console.WriteLine("=== My Bank ===");
    Console.WriteLine("1) Deposit");
    Console.WriteLine("2) Withdraw");
    Console.WriteLine("3) Show Balance");
    Console.WriteLine("4) Exit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Enter amount: ");
            string DepositAmountString = Console.ReadLine();
            int Depositamount = int.Parse(DepositAmountString);
            try
            {
                account.Deposit(Depositamount);
                Console.WriteLine("Deposit successful");
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            break;

        case "2":
            Console.Write("Enter amount: ");
            string WithdrawAmountString = Console.ReadLine();
            int WithdrawAmount = int.Parse(WithdrawAmountString);
            try
            {
                account.Withdraw(WithdrawAmount);
                Console.WriteLine("Withdraw successful");
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            break;

        case "3":
            string balanceString = account.Balance.ToString();
            Console.WriteLine($"Your balance is {balanceString}");
            break;

        case "4":
            running = false;
            break;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }

    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
}
