using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models.DTOs.Responses
{
    public class TodoResponse
    {
        public ItemData Data { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
