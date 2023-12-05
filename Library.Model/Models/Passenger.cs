using System;

namespace Library.Model.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public int PassportNumber { get; set; }
        public int NationalCode { get; set; }
        public DateTime DateOfBirth { get; set; }
        
    }
}
