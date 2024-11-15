namespace ExpenseManagement.Domain;

public class User
{
    private readonly Guid _id;
    private readonly List<Wallet> _wallets;
    private readonly List<Guid> _expenseIds  = [];
    public const int MaxWalletNumber = 3;
    public User(Guid? id, List<Wallet>? wallets)
    {
        _wallets = [];
        foreach (var wallet in wallets ?? [])
        {
            CreateWallet(wallet);
        }
        _id = id ?? Guid.NewGuid();
    }

    public void CreateWallet(Wallet? wallet)
    {
        if (_wallets.Count == MaxWalletNumber)
        {
            throw new InvalidOperationException(
                $"user.must.have.only.{MaxWalletNumber}.max");
        }

        if (wallet is not null
            && _wallets.Any(w => w.Id.Equals(wallet.Id)))
        {
            throw new InvalidOperationException("user.wallet.already.exits");
        }
        wallet ??= Wallet.CreateWallet(id: null);
        _wallets.Add(wallet);
    }

    public void LogExpense(double amount, Guid walletId)
    {
        var expense = Expense.CreateExpense(
            id: null,
            userId: _id,
            amount: amount,
            walletId: walletId);
        
        // Log expense here
        _expenseIds.Add(expense._id);
    }
}
