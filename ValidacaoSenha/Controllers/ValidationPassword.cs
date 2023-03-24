using Microsoft.AspNetCore.Mvc;

namespace ValidacaoSenha.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValidationPassword : ControllerBase
    {
        [HttpGet(Name = "GetPasswordValidation")]
        public IActionResult Get(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 9)
            {
                return BadRequest(new { IsValid = false });
            }

            if (password.Distinct().Count() != password.Length)
            {
                return BadRequest(new { IsValid = false });
            }

            var hasUppercase = password.Any(c => char.IsUpper(c));
            var hasLowercase = password.Any(c => char.IsLower(c));
            var hasDigit = password.Any(c => char.IsDigit(c));
            var hasSpecialCharacter = password.Any(c => !char.IsLetterOrDigit(c));

            if (!(hasUppercase && hasLowercase && hasDigit && hasSpecialCharacter))
            {
                return BadRequest(new { IsValid = false });
            }

                return Ok(new { IsValid = true });
        }
    }
}
