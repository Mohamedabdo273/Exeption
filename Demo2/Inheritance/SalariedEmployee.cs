using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class SalariedEmployee : Employee
    {
        private double bonus;
        private double deductions;

        public void SetBonus(double bonus)
        {
            this.bonus = bonus;
        }
       
        public double GetBonus()
        {
            return this.bonus;
        }

        public void SetDeductions(double deductions)
        {
            this.deductions = deductions;
        }
       
        public double GetDeductions()
        {
            return deductions;
        }
        
    }
}
