namespace ExpenseManagement.Web.Contributors;

/// <summary>
/// 
/// </summary>
/// <param name="id"></param>
/// <param name="name"></param>
public class CreateContributorResponse(int id, string name)
{
  /// <summary>
  /// 
  /// </summary>
  public int Id { get; set; } = id;
  /// <summary>
  /// 
  /// </summary>
  public string Name { get; set; } = name;
}
