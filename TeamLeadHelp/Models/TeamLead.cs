namespace TeamLeadHelp.Models
{
    public class TeamLead
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public List<Developer> Developer { get; set; }
    }
}
