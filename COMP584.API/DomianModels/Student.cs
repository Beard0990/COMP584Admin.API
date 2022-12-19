//using COMP584.API.DataModels;
using System;

namespace COMP584.API.DomianModels
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string ProfileImageUrl { get; set; }
        public Guid GenderId { get; set; }

        //public string MyProperty { get; set; }



        // Navigation
        public Gender Gender { get; set; }
        public Address Address { get; set; }

    }
}
