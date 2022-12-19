using System;

namespace COMP584.API.DomianModels
{
    public class Address
    {
        public Guid Id { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }


        // Navigation
        public Guid StudentId { get; set; }
    }
}
