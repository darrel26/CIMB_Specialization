using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ItemData> GetItemById(int id)
        {
            var item = await _apiDbContext.Items.FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }

        public async Task<IActionResult> CreateItem([FromBody] ItemData data)
        {
            await _apiDbContext.Items.AddAsync(data);
            await _apiDbContext.SaveChangesAsync();
            return new OkResult();
        }

        public async Task<IActionResult> UpdateItemById(int id, [FromBody] ItemData data)
        {
            var existItem = await GetItemById(id);

            if (existItem == null)
            {
                return new NotFoundResult();
            }
            existItem.Title = data.Title;
            existItem.Description = data.Description;
            existItem.Done = data.Done;

            await _apiDbContext.SaveChangesAsync();
            return new OkResult();
        }
    }
}
