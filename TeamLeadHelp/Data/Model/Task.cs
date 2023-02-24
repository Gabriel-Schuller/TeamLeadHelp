namespace TeamLeadHelp.Data.Model
{
    public class Task
    {
        public int ID { get; set; }
public string Title{ get; set; }    
        public string Description { get; set; }
        public int TimeEstimate { get; set; }

        public int ActualTime { get; set; }

        public bool Compleated { get; set; }
    }
}
