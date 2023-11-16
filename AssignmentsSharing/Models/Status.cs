namespace AssignmentsSharing.Models
{
    public enum STypes
    {
        DefaultType,
        Status1,
        Status2,
        Status3

    }
    public class Status
    {
        public Guid Id { get; set; }
        public STypes StatusType { get; set; } = STypes.DefaultType;
        public int OccuranceTime { get; set; }


        public Assignment? Assignment { get; set; } 
    }
}
