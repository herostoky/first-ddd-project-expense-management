using ExpenseManagement.Api.Constants;
using ExpenseManagement.Contracts.Apis.Users.Requests;
using ExpenseManagement.UseCases.Users.SignIn;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManagement.Api.Controllers.Users;


[ApiController]
[Route($"api/{nameof(Routes.User)}")]
public class UserController(ILogger<UserController> logger, ISender sender) : ControllerBase
{
  [HttpPost(template: Routes.User.SignUp, Name = nameof(Routes.User.SignUp))]
  public async Task<IActionResult> UserSignUp()
  {
    logger.LogInformation("Sign up User");
    await Task.Delay(millisecondsDelay: 1000);
    return Ok();
  }

  [HttpPost(template: Routes.User.SignIn, Name = nameof(Routes.User.SignIn))]
  public async Task<IActionResult> UserSignIn([FromBody] UserSignInRequest request, CancellationToken cancellationToken)
  {
    logger.LogInformation("Sign up User");
    var userSignInCommand = new UserSignInCommand();
    await sender.Send(userSignInCommand, cancellationToken);
    await Task.Delay(millisecondsDelay: 1000, cancellationToken);
    return Ok();
  }

  /*[HttpPost(template: Routes.User.SignUp, Name = nameof(Routes.User.SignUp))]
  public BaseResponseDto<UserSignUpResponseDto> UserSignUp(UserSignUpRequestDto userSignUpRequestDto)
  {
    logger.LogDebug(message: "Trying to sign up user : {User}", userSignUpRequestDto);
    var responseDto = userService.UserSignUp(userEmail: userSignUpRequestDto.UserEmail.Trim(),
        userFullName: userSignUpRequestDto.UserFullName.Trim(), userPassword: userSignUpRequestDto.UserPassword);
    var httpCode = Convert.ToInt32(HttpStatusCode.Created);
    return new BaseResponseDto<UserSignUpResponseDto>
    {
      HttpStatusCode = httpCode,
      IsError = false,
      ResponseMessage = "User signed up",
      Body = responseDto
    };
  }

  [HttpPost(template: Routes.User.SignIn, Name = nameof(Routes.User.SignIn))]
  public BaseResponseDto<UserSignInResponseDto> UserSignIn(UserSignInRequestDto userSignInRequestDto)
  {
    logger.LogDebug(message: "Trying to sign in user : {User}", userSignInRequestDto);
    var responseDto = userService.UserSignIn(userEmail: userSignInRequestDto.UserEmail.Trim(), userPassword: userSignInRequestDto.UserPassword);
    var httpCode = Convert.ToInt32(HttpStatusCode.Accepted);
    return new BaseResponseDto<UserSignInResponseDto>
    {
      HttpStatusCode = httpCode,
      IsError = false,
      ResponseMessage = "User signed in",
      Body = responseDto
    };
  }*/

}
