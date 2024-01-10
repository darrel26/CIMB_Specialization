using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Configuration;

namespace TodoApp.Models.DTOs.Responses
{
    public class LoginResponse : AuthResult
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
