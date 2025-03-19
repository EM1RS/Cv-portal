namespace CvAPI2.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string? School { get; set; }
        public string? Degree { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}