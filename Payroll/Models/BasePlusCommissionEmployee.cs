using System;
namespace Payroll.Models
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        public BasePlusCommissionEmployee(string FirstName, string LastName, string SocialSecurityNumber) : base(FirstName, LastName, SocialSecurityNumber)
        {

        }

        public override decimal Earnings()
        {
            return 4.0M;
        }

    }
}
