using Microsoft.EntityFrameworkCore;

namespace AssignmentsSharing.Models
{
    
    public class Assignment
    {
        public Guid Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public int TimeCost { get; set; }
        public int Priority { get; set; }


        public List<Status> Statuses { get; set; } = new List<Status>();

        public Developer? Developer { get; set; }
        public Issue? Issue { get; set; }
    }
}
