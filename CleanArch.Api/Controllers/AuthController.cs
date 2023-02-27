using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Auth;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthenticationUseCase useCase;
        public AuthController(AuthenticationUseCase useCase)
        {
            this.useCase = useCase;

        }

        public async Task<IActionResult> Get([FromBody] string userName, string password)
        {
            useCase.UserName = userName;
            useCase.Password = password;
            var result = await useCase.Execute();
            if (result.Errors.Any())
            {
                return BadRequest();
            }

            return Ok(result.Token);
        }
    }
}