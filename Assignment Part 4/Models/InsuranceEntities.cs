using System.Data.Entity;

namespace InsuranceApp.Models
{
    public class InsuranceEntities : DbContext
    {
        public DbSet<Insuree> Insurees { get; set; }
    }
}
