
namespace BankAccountSystem
{
    /// <summary>
    /// Manages multiple bank accounts.
    /// </summary>
    public class BankAccountManager
    {
        private List<BankAccount> accounts = new List<BankAccount>();

        /// <summary>
        /// Creates a new bank account and adds it to the list of accounts.
        /// </summary>
        /// <param name="owner">The owner of the account.</param>
        /// <param name="balance">The balance of the account.</param>
        public void CreateAccount(string owner, decimal balance)
        {
            var account = new BankAccount(owner, balance);
            accounts.Add(account);
        }

        /// <summary>
        /// Retrieves the bank account associated with the specified owner.
        /// </summary>
        /// <param name="owner">The owner of the account.</param>
        /// <returns>The bank account if found; otherwise, null.</returns>
        public BankAccount GetAccount(string owner)
        {
            return accounts.FirstOrDefault(a => a.Owner == owner);
        }

        /// <summary>
        /// Retrieves all bank accounts.
        /// </summary>
        /// <returns>A list of all bank accounts.</returns>
        public List<BankAccount> GetAllAccounts()
        {
            return new List<BankAccount>(accounts);
        }

        /// <summary>
        /// Deletes the bank account associated with the specified owner.
        /// </summary>
        /// <param name="owner">The owner of the account to delete.</param>
        /// <returns>True if the account was successfully deleted; otherwise, false.</returns>
        public bool DeleteAccount(string owner)
        {
            var account = GetAccount(owner);
            if (account != null)
            {
                accounts.Remove(account);
                return true;
            }
            return false;
        }
    }
}