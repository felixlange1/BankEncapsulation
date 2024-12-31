namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            Console.WriteLine("Press 1 for account balance or 2 to make a deposit");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine($"Your new account balance is {myAccount.GetBalance()}");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Please enter deposit amount");
                double depositAmount = double.Parse(Console.ReadLine());
                myAccount.Deposit(depositAmount);
                Console.WriteLine($"Your new account balance is {myAccount.GetBalance()}");
            }
            
        }
    }
}
