using System;

namespace Classes
{
    public class Customer
    {
        public int Id { get; set; }

        private String _firstName;
        public String FirstName
        {
            get => "Mrs." + _firstName;
            set => _firstName = value;
        }

        public String LastName { get; set; }
        public String City { get; set; }
    }
}