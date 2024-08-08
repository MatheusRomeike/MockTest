
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MockTest.DataAccessLayer.Context
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public virtual DbSet<Employee> M_Employee { get; set; }
    }
}