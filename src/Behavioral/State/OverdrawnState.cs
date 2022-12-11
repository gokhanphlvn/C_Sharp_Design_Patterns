namespace State
{
    /// <summary>
    /// Concrete State
    /// </summary>
    public class OverdrawnState : BankAccountState
    {

        public OverdrawnState(decimal balance, BankAccount bankAccount)
        {
            BankAccount = bankAccount;
            Balance = balance;
        }
        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, depositing {amount}");
            Balance += amount;
            if (Balance >= 0)
            {
                BankAccount.BankAccountState = new RegularState(Balance, BankAccount);
            }
        }

        public override void WithDraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, cannot withdraw balance {Balance}");
            
        }
    }
}
