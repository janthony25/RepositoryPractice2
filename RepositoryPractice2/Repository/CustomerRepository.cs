using Microsoft.EntityFrameworkCore;
using RepositoryPractice2.Data;
using RepositoryPractice2.Models;

namespace RepositoryPractice2.Repository
{
    public class CustomerRepository
    {
        private readonly ApplicationDbContext _db;
        private DbSet<tblCustomer> CustomerEntity;
        private DbSet<tblIssue> IssueEntity;
        public CustomerRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<ViewTblCustomerWithIssue> GetCustomer()
        {
            var customerWithIssue = _db.Set<ViewTblCustomerWithIssue>();
            return customerWithIssue.AsEnumerable();
        }
    }
}
