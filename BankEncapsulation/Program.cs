namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Account = new BankAccount();

            Account.Deposit(4287.80);

            Account.Withdraw(160.00);

            var balance = Account.GetBalance();

            Console.WriteLine(balance);
        }
    }
}
