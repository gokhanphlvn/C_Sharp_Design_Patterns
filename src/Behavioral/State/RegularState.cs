namespace State
{
    /// <summary>
    /// Concrete State
    /// </summary>
    public class RegularState : BankAccountState
    {
        public RegularState(decimal balance, BankAccount bankAccount)
        {
            BankAccount = bankAccount;
            Balance = balance;
        }

        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, depositing {amount}");
            Balance += amount;
        }

        public override void WithDraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, withdrawing {amount} from {Balance}");
            Balance -= amount;
            if (Balance<0)
            {
                BankAccount.BankAccountState = new OverdrawnState(Balance, BankAccount);
            }
        }
    }
}
