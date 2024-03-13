using System.ComponentModel.DataAnnotations;

namespace RepositoryPractice2.Models
{
    public class tblIssue
    {
        [Key]
        public int IssueId { get; set; }
        [Required]
        public string Problem { get; set; }
        [Required]
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        [Required]
        public string CarRego { get; set; }
        public string Description { get; set; }
        public string PaymentStatus { get; set; }
        public string WorkStatus { get; set; }

        public int CustomerId { get; set; }
    }
}
