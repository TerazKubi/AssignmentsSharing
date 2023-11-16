using Microsoft.EntityFrameworkCore;

namespace AssignmentsSharing.Models
{
    [Index(nameof(Pseudonym), IsUnique = true)]
    public class Developer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string Pseudonym { get; set; }

        public List<Developer> Developers { get; set; } = new List<Developer>();
        public List<Issue> Issues { get; set; } = new List<Issue>();
    }
}
