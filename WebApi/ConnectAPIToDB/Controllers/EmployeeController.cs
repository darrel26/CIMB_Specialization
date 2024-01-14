using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ConnectAPIToDB.Models;
using System.Linq;

namespace ConnectAPIToDB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _context;
        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }
        // GET: api/employee
        [HttpGet]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            // return new String[]
            return _context.GetAllEmployee();
        }
        // GET: api/employee/{id}
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            // return new String[]
            return _context.GetEmployee(id);
        }
        // POST: api/employee/add
        [HttpPost("add", Name = "Post")]
        public ActionResult<IEnumerable<EmployeeItem>> PostEmployeeItem([FromBody] EmployeeItem item)
        {
            if (ModelState.IsValid)
            {
                _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
                _context.AddEmployee(item);
                return new JsonResult(item) { StatusCode = 200 };
            }
            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }
        // PUT: api/employee/{id}
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<EmployeeItem>> EditEmployeeName(int id, String nama)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            var employee = _context.GetEmployee(id);

            if (employee != null)
            {
                _context.EditEmployeeName(id, nama);
                return new JsonResult(employee) { StatusCode = 200 };
            }
            else
            {
                return NotFound(); 
            }
        }
    }
}
