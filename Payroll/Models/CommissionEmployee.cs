using System;
namespace Payroll.Models
{
    public class CommissionEmployee : Employee
    {
        public CommissionEmployee(string FirstName, string LastName, string SocialSecurityNumber) : base(FirstName, LastName, SocialSecurityNumber)
        {
        }
        public override decimal Earnings()
        {
            return 3.0M;
        }
    }
}
