namespace Csharp_Term2_Fall_1404.Entities
{
    public class Wallet
    {
        public double Balance { get; set; }
        public void GetBalance()
        {
            Console.WriteLine(Balance);
        }

        public void Deposit(double value)
        {
            Balance = Balance + value;
        }

        public void Withdraw(double value)
        {
            if (value > Balance)
            {
                Console.WriteLine("Adam mojodi");
            }
            else
            {
                Balance = Balance - value;
            }
        }
    }
}
