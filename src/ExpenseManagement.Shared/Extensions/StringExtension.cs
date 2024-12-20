using System.Globalization;

namespace ExpenseManagement.Shared.Extensions;

public static class StringExtension
{
  public static string ReplaceRegex(this string input, System.Text.RegularExpressions.Regex regex, string replacement)
  {
    ArgumentNullException.ThrowIfNull(regex);
    return regex.Replace(input, replacement);
  }

  public static string ToSnakeCase(this string input) => ToSnakeCase(input, CultureInfo.InvariantCulture);

  public static string ToSnakeCase(this string input, CultureInfo culture)
  {
    if (string.IsNullOrWhiteSpace(input))
    {
      return input;
    }

    return input
      // Replace spaces and dashes with underscores
      .ReplaceRegex(RegexPatterns.SpacesAndDashes(), replacement: "_")
      // Insert underscores between lowercase and uppercase letters
      .ReplaceRegex(RegexPatterns.UpperCaseFollowingLowerCase(), replacement: "$1_$")
      // Lower case all
      .ToLower(culture);
  }
}

internal static partial class RegexPatterns
{
  [System.Text.RegularExpressions.GeneratedRegex("[\\s-]+")]
  public static partial System.Text.RegularExpressions.Regex SpacesAndDashes();

  [System.Text.RegularExpressions.GeneratedRegex("([a-z0-9])([A-Z])")]
  public static partial System.Text.RegularExpressions.Regex UpperCaseFollowingLowerCase();
}
