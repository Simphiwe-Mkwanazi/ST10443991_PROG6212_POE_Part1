namespace CMCS.Web.Models
{
    public class Claim
    {
        public Guid ClaimId { get; set; }
        public Guid LecturerId { get; set; }
        public int PeriodMonth { get; set; }
        public int PeriodYear { get; set; }
        public decimal TotalHours { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal CalculatedAmount { get; set; }
        public string Status { get; set; } = "Draft";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
