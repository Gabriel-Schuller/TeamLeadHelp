namespace TeamLeadHelp.Data.Model
{
    public class DevTask
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int HoursEstimated { get; set; }
        public int WorkedHours { get; set; }
        public bool IsFinished{ get; set; }
        public bool OnHold{ get; set; }
    }
}
