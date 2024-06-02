using BankAccountSystem;

namespace BankAccountTests;

public class BankAccountManagerTests
{
    [Fact]
    public void CreateAccount_ValidData_AccountCreated()
    {
        // Arrange
        var manager = new BankAccountManager();

        // Act
        manager.CreateAccount("José", 1000);
        var account = manager.GetAccount("José");

        // Assert
        Assert.NotNull(account);
        Assert.Equal("José", account.Owner);
        Assert.Equal(1000, account.Balance);
    }

    [Fact]
    public void GetAccount_NonExistentOwner_ReturnsNull()
    {
        // Arrange
        var manager = new BankAccountManager();

        // Act
        var account = manager.GetAccount("Non Existent");

        // Assert
        Assert.Null(account);
    }

    [Fact]
    public void GetAllAccounts_MultipleAccounts_ReturnsAllAccounts()
    {
        // Arrange
        var manager = new BankAccountManager();
        manager.CreateAccount("José", 1000);
        manager.CreateAccount("Maria", 1500);

        // Act
        var accounts = manager.GetAllAccounts();

        // Assert
        Assert.Equal(2, accounts.Count);
        Assert.Contains(accounts, a => a.Owner == "José");
        Assert.Contains(accounts, a => a.Owner == "Maria");
    }

    [Fact]
    public void DeleteAccount_ExistingAccount_ReturnsTrueAndDeletesAccount()
    {
        // Arrange
        var manager = new BankAccountManager();
        manager.CreateAccount("José", 1000);

        // Act
        var result = manager.DeleteAccount("José");
        var account = manager.GetAccount("José");

        // Assert
        Assert.True(result);
        Assert.Null(account);
    }

    [Fact]
    public void DeleteAccount_NonExistentAccount_ReturnsFalse()
    {
        // Arrange
        var manager = new BankAccountManager();

        // Act
        var result = manager.DeleteAccount("Non Existent");

        // Assert
        Assert.False(result);
    }
}