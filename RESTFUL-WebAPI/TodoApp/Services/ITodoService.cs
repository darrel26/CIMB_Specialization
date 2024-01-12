using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.Services
{
    public interface ITodoService
    {
        Task<ItemData> GetItemById(int id);
        Task<IActionResult> CreateItem(ItemData itemData);
        Task<IActionResult> UpdateItemById(int id, ItemData itemData);
    }
}
