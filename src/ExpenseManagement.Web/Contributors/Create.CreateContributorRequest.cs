using System.ComponentModel.DataAnnotations;

namespace ExpenseManagement.Web.Contributors;

/// <summary>
/// 
/// </summary>
public class CreateContributorRequest
{
  /// <summary>
  /// 
  /// </summary>
  public const string Route = "/Contributors";

  /// <summary>
  /// 
  /// </summary>
  [Required]
  public string? Name { get; set; }
  /// <summary>
  /// 
  /// </summary>
  public string? PhoneNumber { get; set; }
}
