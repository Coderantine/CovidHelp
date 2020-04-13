using System.Collections.Generic;

namespace CovidHelp.Data.Entities
{
    public class HelpRequest : EntityBase
    {
        public HelpRequestStatus Status { get; set; }
        public long AppUserId { get; set; }
        public long CityId { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public virtual City City { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<HelpRequestTag> Tags { get; set; }
        public virtual ICollection<HelpRequestItem> Items { get; set; }
    }
}