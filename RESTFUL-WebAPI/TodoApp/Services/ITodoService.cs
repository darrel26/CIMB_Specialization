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
        Task<List<ItemData>> GetItems();
        Task<ItemData> GetItemById(int id);
        Task<ItemData> CreateItem(ItemData itemData);
        Task<ItemData> UpdateItemById(int id, ItemData itemData);
        Task<ItemData> DeleteItemById(int id);
    }
}
