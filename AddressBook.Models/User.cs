using System;

namespace AddressBook.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string LandLine { get; set; }
        public Uri Website { get; set; }
        public string Profession { get; set; }


    }
}
