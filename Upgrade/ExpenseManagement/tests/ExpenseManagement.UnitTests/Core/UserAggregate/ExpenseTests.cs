using ExpenseManagement.Core.UserAggregate;
using ExpenseManagement.UnitTests.Core.UserAggregate.TestUtils.Users;
using ExpenseManagement.UnitTests.Core.UserAggregate.TestUtils.Wallets;

namespace ExpenseManagement.UnitTests.Core.UserAggregate;

public class ExpenseTests
{
    [Fact]
    public void LogExpense_WhenAmountIsNegativeOrZero_ShouldFail()
    {
        // Arrange
        // Create a wallet
        var wallet = WalletFactory.CreateWallet(id: null);
        // Create a user
        var user = UserFactory.CreateUser(id: null, wallets: [wallet]);
        
        // Act
        // Log expense : zero amount
        Action logExpenseZeroAmountAction = () => 
            user.LogExpense(amount: 0, walletId: wallet.Id);
        // Log expense : negative amount
        Action logExpenseNegativeAmountAction = () => 
            user.LogExpense(amount: -1, walletId: wallet.Id);
        
        // Assert
        logExpenseZeroAmountAction.Should()
            .Throw<ArgumentOutOfRangeException>(
                because: "amount.must.be.greater.than.zero");
        logExpenseNegativeAmountAction.Should()
            .Throw<ArgumentOutOfRangeException>(
                because: "amount.must.be.greater.than.zero");
    }
    
    [Fact]
    public void LogExpense_WhenAmountHasMoreThanAllowedDecimal_ShouldFail()
    {
        // Arrange
        // Create a wallet
        var wallet = WalletFactory.CreateWallet(id: null);
        // Create a user
        var user = UserFactory.CreateUser(id: null, wallets: [wallet]);
        
        // Act
        // Log expense : invalid amount
        Action logExpenseInvalidAmountAction = () => 
            user.LogExpense(amount: 2.3334, walletId: wallet.Id);
        // Log expense : invalid amount
        Action logExpenseInvalidAmountAction2 = () => 
            user.LogExpense(amount: 56100.023, walletId: wallet.Id);
        
        // Assert
        logExpenseInvalidAmountAction.Should()
            .Throw<ArgumentException>(
                because:
                $"amount.must.have.only.{Expense.AmountDecimalPrecision}.decimals");
        logExpenseInvalidAmountAction2.Should()
            .Throw<ArgumentException>(
                because:
                $"amount.must.have.only.{Expense.AmountDecimalPrecision}.decimals");
    }
}
