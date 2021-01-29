using System;

namespace Core.Entities
{
    public class PortfolioItem : EntityBase
    {
        public String ProjectName { get; set; }
        public String Description { get; set; }
        public String ImageUrl { get; set; }
    }
}
