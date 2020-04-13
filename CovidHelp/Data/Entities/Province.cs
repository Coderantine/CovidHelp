using System.Collections.Generic;

namespace CovidHelp.Data.Entities
{
    public class Province : EntityBase
    {
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}