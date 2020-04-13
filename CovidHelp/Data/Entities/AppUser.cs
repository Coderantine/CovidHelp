using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CovidHelp.Data.Entities
{
    public class AppUser : IdentityUser<long>
    {
        public string ShortStory { get; set; }
        public ICollection<HelpRequest> HelpRequests { get; set; }
        public ICollection<HelpRequestItemAppUser> HelpedRequests { get; set; }
    }
}