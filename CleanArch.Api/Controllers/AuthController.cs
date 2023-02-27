using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Api.Models;
using CleanArch.Domain.Auth;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthenticationUseCase _useCase;
        public AuthController(AuthenticationUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Run([FromBody] AuthRequest credentials)
        {
            _useCase.SetCredentials(credentials.UserName, credentials.Password);

            var result = await _useCase.Execute();
            return result.Errors.Any()
                ? BadRequest(AuthResponse.Fail(result.Errors))
                : Ok(AuthResponse.Success(result.Token));
        }
    }
}