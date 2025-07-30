using System;

class Banking
{
    class BankAccount
    {
        private string? name;
        private int age;
        private int balance;

        public BankAccount()
        {
            Console.WriteLine("Enter your starting balance:");
            balance = Convert.ToInt32(Console.ReadLine());
        }

        public void CreateAccount()
        {
            Console.WriteLine("Enter your Full Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter your Age:");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void DepositMoney()
        {
            Console.WriteLine("Enter the amount to deposit:");
            int deposit = Convert.ToInt32(Console.ReadLine());
            balance += deposit;
            Console.WriteLine($"Successfully deposited {deposit}");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Enter the amount to withdraw:");
            int withdraw = Convert.ToInt32(Console.ReadLine());

            if (withdraw > balance)
            {
                Console.WriteLine("Not enough balance! Try a smaller amount.");
            }
            else
            {
                balance -= withdraw;
                Console.WriteLine($"Successfully withdrew {withdraw}");
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"The Current Balance is {balance}");
        }
    }

    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        account.CreateAccount();

        char ch;

        do
        {
            Console.WriteLine("\n--- Simple Bank Menu ---");
            Console.WriteLine("1. Deposit Money");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    account.DepositMoney();
                    break;

                case 2:
                    account.WithdrawMoney();
                    break;

                case 3:
                    account.CheckBalance();
                    break;

                case 4:
                    Console.WriteLine("Thank you for using Simple Bank!");
                    return;

                default:
                    Console.WriteLine("Please enter a valid choice!");
                    break;
            }

            Console.WriteLine("Back to Menu? (Y/n)");
            ch = Convert.ToChar(Console.ReadLine());
        } while (ch == 'y' || ch == 'Y');
    }
}
