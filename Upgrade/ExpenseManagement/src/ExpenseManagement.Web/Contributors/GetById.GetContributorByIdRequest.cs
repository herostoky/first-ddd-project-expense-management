namespace ExpenseManagement.Web.Contributors;

/// <summary>
/// 
/// </summary>
public class GetContributorByIdRequest
{
  /// <summary>
  /// 
  /// </summary>
  public const string Route = "/Contributors/{ContributorId:int}";
  /// <summary>
  /// 
  /// </summary>
  /// <param name="contributorId"></param>
  /// <returns></returns>
  public static string BuildRoute(int contributorId) => Route.Replace("{ContributorId:int}", contributorId.ToString());

  /// <summary>
  /// 
  /// </summary>
  public int ContributorId { get; set; }
}
