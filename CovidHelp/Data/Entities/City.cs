namespace CovidHelp.Data.Entities
{
    public class City : EntityBase
    {
        public long ProvinceId { get; set; }
        public string Name { get; set; }
        public virtual Province Province { get; set; }
    }
}
