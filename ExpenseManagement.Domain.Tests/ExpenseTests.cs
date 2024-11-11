using ExpenseManagement.Domain.Tests.TestUtils;
using ExpenseManagement.Domain.Tests.TestUtils.Users;
using FluentAssertions;

namespace ExpenseManagement.Domain.Tests;

public class ExpenseTests
{
    [Fact]
    public void LogExpense_WhenAmountIsNegativeOrZero_ShouldFail()
    {
        // Arrange
        // Create a wallet
        var wallet = WalletFactory.CreateWallet(id: null);
        // Create a user
        var user = UserFactory.CreateUser(id: null, walletIds: [wallet.Id]);
        
        // Act
        // Log expense : zero amount
        var logExpenseZeroAmountAction = () => 
            user.LogExpense(amount: 0, walletId: wallet.Id);
        // Log expense : negative amount
        var logExpenseNegativeAmountAction = () => 
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
        var user = UserFactory.CreateUser(id: null, walletIds: [wallet.Id]);
        
        // Act
        // Log expense : invalid amount
        var logExpenseInvalidAmountAction = () => 
            user.LogExpense(amount: 2.3334, walletId: wallet.Id);
        // Log expense : invalid amount
        var logExpenseInvalidAmountAction2 = () => 
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
