﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WemaBankTask.Entities.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string StateOfResidence { get; set; }
        public string LGA { get; set; }
        public bool IsVerified { get; set; }
    }
}
