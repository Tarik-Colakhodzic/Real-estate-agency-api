﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAgency.Model.Requests
{
    public class UserInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }

        [EmailAddress()]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Username { get; set; }

        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$")]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmedPassword { get; set; }

        //public bool? Status { get; set; }
        public List<int> Roles { get; set; } = new List<int>();
    }
}