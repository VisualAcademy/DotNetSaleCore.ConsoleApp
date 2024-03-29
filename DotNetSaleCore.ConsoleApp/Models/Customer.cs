﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetSaleCore.ConsoleApp.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
