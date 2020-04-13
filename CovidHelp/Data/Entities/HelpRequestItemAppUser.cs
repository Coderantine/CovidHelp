namespace CovidHelp.Data.Entities
{
    public class HelpRequestItemAppUser
    {
        public long HelpRequestItemId { get; set; }
        public long AppUserId { get; set; }
        public virtual HelpRequestItem HelpRequestItem { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}