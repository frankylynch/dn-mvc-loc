using System;
namespace dnmvcloc.Models
{
    public class Grouping
    {
        public Grouping() { }

        public enum GroupingTypeEnum { Item = 1, Location, User }

        public GroupingTypeEnum GroupType { get; set; }

        public int GroupingId { get; set; }
        public int GroupingItemId { get; set; }

    }
}
