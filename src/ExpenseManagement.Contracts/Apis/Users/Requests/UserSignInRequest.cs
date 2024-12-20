using System.Text.Json.Serialization;

namespace ExpenseManagement.Contracts.Apis.Users.Requests;

public record UserSignInRequest(
  [property: JsonPropertyName("email_address")]
  string emailAddress,

  [property: JsonPropertyName("password")]
  string clearTextPassword);
