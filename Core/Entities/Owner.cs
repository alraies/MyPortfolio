using System;

namespace Core.Entities
{
    public class Owner :EntityBase
    {
        public String FullName { get; set; }
        public String Profile { get; set; }
        public String Avatar { get; set; }
        public String Video { get; set; }
        public Address Address { get; set; }

    }
}
