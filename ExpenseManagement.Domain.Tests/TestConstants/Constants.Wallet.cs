﻿namespace ExpenseManagement.Domain.Tests.TestConstants;

public static partial class Constants
{
    public static class Wallet
    {
        public static readonly Guid Id = Guid.NewGuid();
        public static readonly Domain.Wallet DefaultWallet = new(Id);
    }
}
