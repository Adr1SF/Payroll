﻿using System;

namespace Payroll.Models
{
    public abstract class Employee
    {
        public string FirstName { get;  }
        public string LastName { get;  }
        public string SocialSecurityNumber { get;  }

        public Employee(string FirstName, string LastName, string SocialSecurityNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.SocialSecurityNumber = SocialSecurityNumber;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} : {SocialSecurityNumber} -> {Earnings()}";
        }
        public abstract decimal Earnings();
    }
}

