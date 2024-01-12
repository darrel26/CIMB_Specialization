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
        //private readonly apidbcontext _context;
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        //[httpget, authorize(authenticationschemes = jwtbearerdefaults.authenticationscheme)]
        //public async task<iactionresult> getitems()
        //{
        //    var items = await _context.items.tolistasync();
        //    return ok(items);
        //}

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
                catch (Exception err)
                {
                    return BadRequest(new TodoResponse()
                    {
                        Data = data,
                        Success = true,
                        Errors = new List<string> { err.Message }
                    });
                }
            }

            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            return BadRequest(new TodoResponse()
            {
                Data = data,
                Success = true,
                Errors = errors
            });
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
                if (id != data.Id)
                {
                    return BadRequest();
                }

            try
            {
                await _todoService.UpdateItemById(id, data);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }

            return Ok($"successfully changed item data with id {id}");
        }

        //[httpdelete("{id}")]
        //public async task<iactionresult> deleteitem(int id)
        //{
        //    var existitem = await _context.items.firstordefaultasync(x => x.id == id);

        //    if (existitem == null)
        //        return notfound();

        //    _context.items.remove(existitem);
        //    await _context.savechangesasync();

        //    return ok(existitem);
        //}
    }
}
