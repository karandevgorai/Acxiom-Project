namespace AcxiomCRM.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        public string Subject { get; set; } = string.Empty;

        public DateTime ContactDate { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; } = null!;
    }
}