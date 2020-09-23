using System;
using Payroll.Models;

namespace Payroll
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Payroll......");

            //Employee ee = new Employee("Bruce", "Wayne", "BAT001");
            //Console.WriteLine(ee.ToString());

            HourlyEmployee he = new HourlyEmployee("Diane", "Carter", "WW001");
            Console.WriteLine(he.ToString());

            SalariedEmployee se = new SalariedEmployee("Barry", "Allen", "FLASH001");
            Console.WriteLine(se.ToString());

            CommissionEmployee ce = new CommissionEmployee("Peter", "Parker", "SPIDER001");
            Console.WriteLine(ce.ToString());

            BasePlusCommissionEmployee bce = new BasePlusCommissionEmployee("Clark", "Kent", "SUPER001");
            Console.WriteLine(bce.ToString());

        }
    }
}
