using RepositoryPractice2.Models;

namespace RepositoryPractice2.Repository
{
    public interface ICustomerRepository
    {
        public IEnumerable<ViewTblCustomerWithIssue> GetCustomer();
    }
}
