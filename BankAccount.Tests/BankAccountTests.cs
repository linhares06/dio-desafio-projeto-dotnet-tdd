using BankAccountSystem;

namespace BankAccountTests;

    public class BankAccountTests
    {
        [Fact]
        public void CreateAccount_ValidInitialBalance_AccountCreated()
        {
            // Arrange
            var account = new BankAccount("José", 1000);

            // Act
            var balance = account.Balance;

            // Assert
            Assert.Equal(1000, balance);
        }

        [Fact]
        public void Deposit_ValidAmount_IncreasesBalance()
        {
            // Arrange
            var account = new BankAccount("José", 1000);

            // Act
            account.Deposit(500);

            // Assert
            Assert.Equal(1500, account.Balance);
        }

        [Fact]
        public void Deposit_NegativeAmount_ThrowsArgumentException()
        {
            // Arrange
            var account = new BankAccount("José", 1000);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => account.Deposit(-500));
        }

        [Fact]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            // Arrange
            var account = new BankAccount("José", 1000);

            // Act
            account.Withdraw(500);

            // Assert
            Assert.Equal(500, account.Balance);
        }

        [Fact]
        public void Withdraw_NegativeAmount_ThrowsArgumentException()
        {
            // Arrange
            var account = new BankAccount("José", 1000);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => account.Withdraw(-500));
        }

        [Fact]
        public void Withdraw_MoreThanBalance_ThrowsInvalidOperationException()
        {
            // Arrange
            var account = new BankAccount("José", 1000);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(1500));
        }
    }
