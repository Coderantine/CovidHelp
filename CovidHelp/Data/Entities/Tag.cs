using System.Collections.Generic;

namespace CovidHelp.Data.Entities
{
    public class Tag : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<HelpRequestTag> HelpRequests { get; set; }
    }
}