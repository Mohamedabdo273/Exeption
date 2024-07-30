using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class HourlyEmployee : Employee
    {
        private double workingHours;
        private double hourRate;

        public void SetWorkingHours(double workingHours)
        {
            this.workingHours = workingHours;
        }
        public double GetWorkingHours()
        {
            return this.workingHours;
        }
        public void SetHourRate(double hourRate)
        {
            this.hourRate = hourRate;
        }
        public double GetHourRate()
        {
            return hourRate;
        }
    }
}
