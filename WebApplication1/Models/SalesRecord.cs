
using System.ComponentModel.DataAnnotations;

namespace AcxiomCRM.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; } = string.Empty;

        [Range(0.01, 100000000)]
        public decimal Amount { get; set; }

        public DateTime SaleDate { get; set; } = DateTime.Today;

        // Identity user ID of the employee who owns this record
        [Required]
        public string OwnerId { get; set; } = string.Empty;
    }
}