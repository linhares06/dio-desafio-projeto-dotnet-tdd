namespace BankAccountSystem
{
    /// <summary>
    /// Represents a bank account with basic operations such as deposit and withdraw.
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Gets the owner of the bank account.
        /// </summary>
        public string Owner { get; }

        /// <summary>
        /// Gets the balance of the bank account.
        /// </summary>
        public decimal Balance { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class.
        /// </summary>
        /// <param name="owner">The owner of the account.</param>
        /// <param name="balance">The balance of the account.</param>
        public BankAccount(string owner, decimal balance)
        {
            Owner = owner;
            Balance = balance;
        }

        /// <summary>
        /// Deposits the specified amount to the account.
        /// </summary>
        /// <param name="amount">The amount to deposit.</param>
        /// <exception cref="ArgumentException">Thrown when the amount is less than or equal to zero.</exception>
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            Balance += amount;
        }

        /// <summary>
        /// Withdraws the specified amount from the account.
        /// </summary>
        /// <param name="amount">The amount to withdraw.</param>
        /// <exception cref="ArgumentException">Thrown when the amount is less than or equal to zero.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the amount exceeds the current balance.</exception>
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            Balance -= amount;
        }
    }
}