using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Api.Models
{
    public class AuthRequest
    {
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}