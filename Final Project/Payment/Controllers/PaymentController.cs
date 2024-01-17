using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Payment.Data;
using Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly ApiDbContext _apiDbContext;

        public PaymentController(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPayment()
        {
            var listOfPayment = await _apiDbContext.paymentData.ToListAsync();
            return Ok(listOfPayment);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPaymentById(int id)
        {
            var payment = await _apiDbContext.paymentData.FirstOrDefaultAsync(x => x.PaymentDetailId == id);

            if(payment == null)
            {
                return NotFound();
            };

            return Ok(payment);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePayment([FromBody] PaymentData data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _apiDbContext.paymentData.AddAsync(data);
                    await _apiDbContext.SaveChangesAsync();

                    return CreatedAtAction("GetPaymentById", new { id = data.PaymentDetailId }, data);
                }
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePayment(int id, [FromBody] PaymentData data)
        {
            if (id != data.PaymentDetailId)
            {
                return BadRequest();
            }

            var existItem = await 
                _apiDbContext.paymentData.FirstOrDefaultAsync(x => x.PaymentDetailId == id);

            if (existItem == null)
            {
                return NotFound();
            }


            existItem.CardNumber = data.CardNumber;
            existItem.CardOwnerName = data.CardOwnerName;
            existItem.ExpirationDate = data.ExpirationDate;
            existItem.SecurityCode = data.SecurityCode;

            await _apiDbContext.SaveChangesAsync();

            return Ok($"Successfully changed payment data with id {id}");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _apiDbContext.paymentData.FirstOrDefaultAsync(x => x.PaymentDetailId == id);

            if (existItem == null)
                return NotFound();

            _apiDbContext.paymentData.Remove(existItem);
            await _apiDbContext.SaveChangesAsync();

            return new JsonResult(Ok(existItem)) { StatusCode = 204 };
        }

    }
}
