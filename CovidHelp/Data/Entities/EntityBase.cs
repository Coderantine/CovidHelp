using System;

namespace CovidHelp.Data.Entities
{
    public class EntityBase
    {
        public long Id { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}