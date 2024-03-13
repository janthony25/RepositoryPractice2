using System.ComponentModel.DataAnnotations;

namespace RepositoryPractice2.Models
{
    public class tblCustomer
    {
        [Key]
        public int Customer { get; set; }
        [Required]
        public string CustomerName { get; set; }
    }
}
