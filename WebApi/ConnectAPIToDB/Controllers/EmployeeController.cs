using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ConnectAPIToDB.Models;

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
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            // return new String[]
            return _context.GetAllEmployee();
        }

        // GET: api/employee/{id}
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            // return new String[]
            return _context.GetEmployee(id);
        }

        // POST: api/employee/add
        [HttpPost]
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
    }
}
