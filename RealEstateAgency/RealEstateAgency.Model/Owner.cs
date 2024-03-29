﻿namespace RealEstateAgency.Model
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }

        public string CityName => City?.Name;
        public string FullName => $"{FirstName} {LastName}";
    }
}