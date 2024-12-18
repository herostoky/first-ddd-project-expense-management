using ExpenseManagement.Core.UserAggregate;
using ExpenseManagement.UnitTests.Core.UserAggregate.TestUtils.Users;
using ExpenseManagement.UnitTests.Core.UserAggregate.TestUtils.Wallets;

namespace ExpenseManagement.UnitTests.Core.UserAggregate;

public class WalletTests
{
    [Fact]
    public void CreateWallet_WhenMaxWalletNumberExceeded_ShouldFail()
    {
        // Arrange
        // Create wallets
        var wallet1 = WalletFactory.CreateWallet(id: Guid.NewGuid());
        var wallet2 = WalletFactory.CreateWallet(id: Guid.NewGuid());
        var wallet3 = WalletFactory.CreateWallet(id: Guid.NewGuid());
        var walletExceeded = WalletFactory.CreateWallet(id: null);
        // Create a user
        var user = UserFactory.CreateUser(
            id: null,
            wallets: [wallet1, wallet2, wallet3]);
        
        // Act
        // Add wallet
        Action addMoreWalletAction = () => 
            user.CreateWallet(walletExceeded);
        
        // Assert
        addMoreWalletAction.Should()
            .Throw<InvalidOperationException>(
                because: $"user.must.have.only.{User.MaxWalletNumber}.max");
    }
    
    [Fact]
    public void CreateWallet_AddingExistingWallet_ShouldFail()
    {
        // Arrange
        // Create wallets
        var wallet1 = WalletFactory.CreateWallet(id: Guid.NewGuid());
        var wallet2 = WalletFactory.CreateWallet(id: Guid.NewGuid());
        var wallet3 = WalletFactory.CreateWallet(id: Guid.NewGuid());
        var sameWallet = wallet3;
        // Create a user
        var user = UserFactory.CreateUser(
            id: null,
            wallets: [wallet1, wallet2]);
        
        // Act
        // Add wallet
        user.CreateWallet(wallet3);
        Action addSameWalletAction = () => 
            user.CreateWallet(sameWallet);
        
        // Assert
        addSameWalletAction.Should()
            .Throw<InvalidOperationException>(
                because: "user.wallet.already.exits");
    }
}
