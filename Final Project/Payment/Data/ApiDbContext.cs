using Microsoft.EntityFrameworkCore;
using Payment.Models;

namespace Payment.Data
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<PaymentData> paymentData { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}
