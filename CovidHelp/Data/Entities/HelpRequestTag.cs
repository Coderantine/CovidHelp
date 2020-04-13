namespace CovidHelp.Data.Entities
{
    public class HelpRequestTag
    {
        public long HelpRequestId { get; set; }
        public long TagId { get; set; }
        public virtual HelpRequest HelpRequest { get; set; }
        public virtual Tag Tag { get; set; }
    }
}