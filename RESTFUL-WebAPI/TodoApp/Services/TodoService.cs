using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Services
{
    public class TodoService : ITodoService
    {
        private readonly ApiDbContext _apiDbContext;

        public TodoService(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        public async Task<List<ItemData>> GetItems()
        {
            var items = await _apiDbContext.Items.ToListAsync();
            return items;
        }

        public async Task<ItemData> GetItemById(int id)
        {
            var item = await _apiDbContext.Items.FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }

        public async Task<ItemData> CreateItem([FromBody] ItemData data)
        {
            await _apiDbContext.Items.AddAsync(data);
            await _apiDbContext.SaveChangesAsync();
            return data;
        }

        public async Task<ItemData> UpdateItemById(int id, [FromBody] ItemData data)
        {
            var existItem = await GetItemById(id);

            if (existItem == null)
            {
                return null;
            }

            existItem.Title = data.Title;
            existItem.Description = data.Description;
            existItem.Done = data.Done;

            await _apiDbContext.SaveChangesAsync();
            return existItem;
        }

        public async Task<ItemData> DeleteItemById(int id)
        {
            var existItem = await GetItemById(id);

            if(existItem == null)
            {
                return null;
            }

            _apiDbContext.Remove(existItem);
            await _apiDbContext.SaveChangesAsync();

            return existItem;
        }
    }
}
