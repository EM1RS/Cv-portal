namespace MyWebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string SurName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public bool Admin { get; set; } = false;

        public List<WorkExperience> WorkExperiences { get; set; } = new();
        public List<Education> Educations { get; set; } = new();
    }
}