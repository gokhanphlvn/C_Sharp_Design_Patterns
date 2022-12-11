namespace State
{
    /// <summary>
    /// Context
    /// </summary>
    public class BankAccount
    {
        public BankAccount()
        {
            BankAccountState = new RegularState(200, this);
        }
        public BankAccountState BankAccountState { get; set; }
        public decimal Balance { get { return BankAccountState.Balance; } }

        public void Deposit(decimal amount)
        {
            BankAccountState.Deposit(amount);
        }

        public void Withdraw(decimal amount)
        {
            BankAccountState.WithDraw(amount);
        }
    }
}
