using System.ComponentModel.DataAnnotations;

namespace ExpenseManagement.Web.Contributors;

/// <summary>
/// 
/// </summary>
public class UpdateContributorRequest
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

  /// <summary>
  /// 
  /// </summary>
  [Required]
  public int Id { get; set; }
  /// <summary>
  /// 
  /// </summary>
  [Required]
  public string? Name { get; set; }
}
