using System.Collections.Generic;

namespace CovidHelp.Data.Entities
{
    public class HelpRequestItem : EntityBase
    {
        public long HelpRequestId { get; set; }
        public string Name { get; set; }
        public virtual HelpRequest HelpRequest { get; set; }
        public virtual ICollection<HelpRequestItemAppUser> HelpedBy { get; set; }
    }
}