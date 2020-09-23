using System;
namespace Payroll.Models
{
    public class SalariedEmployee : Employee
    {
        public SalariedEmployee(string FirstName, string LastName, string SocialSecurityNumber) : base(FirstName, LastName, SocialSecurityNumber)
        {
        }
        public override decimal Earnings()
        {
            return 2.0M;
        }
    }
}
