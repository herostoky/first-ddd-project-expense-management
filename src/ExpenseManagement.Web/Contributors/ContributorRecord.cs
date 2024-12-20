namespace ExpenseManagement.Web.Contributors;

/// <summary>
/// 
/// </summary>
/// <param name="Id"></param>
/// <param name="Name"></param>
/// <param name="PhoneNumber"></param>
public record ContributorRecord(int Id, string Name, string? PhoneNumber);
