namespace ExpenseManagement.Web.Contributors;

/// <summary>
/// 
/// </summary>
/// <param name="contributor"></param>
public class UpdateContributorResponse(ContributorRecord contributor)
{
  /// <summary>
  /// 
  /// </summary>
  public ContributorRecord Contributor { get; set; } = contributor;
}
