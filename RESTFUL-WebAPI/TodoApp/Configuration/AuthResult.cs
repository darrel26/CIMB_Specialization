﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Configuration
{
    public class AuthResult
    {   
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
