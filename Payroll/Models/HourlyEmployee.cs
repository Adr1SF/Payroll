using System;

namespace Payroll.Models
{
    public class HourlyEmployee : Employee //Permet d'accéder directement aux fonctions de la class employee et aussi de les modifs
    {
        private decimal HourlyWage;
        private decimal HoursWorked;

        public HourlyEmployee(string FirstName, string LastName, string SocialSecurityNumber, decimal HourlyWage, decimal HoursWorked ):base(FirstName, LastName, SocialSecurityNumber)
        {
            this.HourlyWage = HourlyWage;
            this.HoursWorked = HoursWorked;
        }

        public decimal Wage
        {
            get { return HourlyWage; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),value, $"{nameof(Wage)} must be > 0");
                }
                else
                {
                    HourlyWage = value;
                }
            }
        }

        public decimal Hours
        {
            get { return HoursWorked; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),value, $"{nameof(Hours)} must be > 0");
                }
                else
                {
                    HoursWorked = value;
                }

            }
        }


        public override decimal Earnings()
        {
            if (HoursWorked < 40)
            {
                return Wage * Hours;
            }
            else
            {
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
            }
        }
    }
}
