using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Data;
using TodoApp.Models;
using TodoApp.Models.DTOs.Responses;
using TodoApp.Services;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        private BadRequestObjectResult ErrorHandler()
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            return BadRequest(new TodoResponse()
            {
                Data = null,
                Success = false,
                Errors = errors
            });
        }

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        // [HttpGet, Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            try
            {
                List<ItemData> items = await _todoService.GetItems();
                return Ok(items);
            }
            catch (Exception)
            {
                return ErrorHandler();
            }
        } 

        [HttpPost]
        public async Task<IActionResult> CreateItem([FromBody] ItemData data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _todoService.CreateItem(data);

                    return Ok(new TodoResponse()
                    {
                        Data = data,
                        Success = true,
                        Errors = null
                    });
                }
                catch (Exception)
                {
                    return ErrorHandler();
                }
            }

            return ErrorHandler();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItemById(int id)
        {
            var item = await _todoService.GetItemById(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItemById(int id, [FromBody] ItemData data)
        {
            if (id != data.Id)
            {
                return ErrorHandler();
            }

            var result = await _todoService.UpdateItemById(id, data);

            if (result == null)
            {
                return NotFound();
            }

            return Ok($"successfully changed item data with id {id}");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {

            try
            {
                var result = await _todoService.DeleteItemById(id);

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(new TodoResponse()
                {
                    Data = result,
                    Success = true,
                    Errors = null
                });
            }
            catch (Exception)
            {
                return ErrorHandler();
            }
        }

        
    }
}
