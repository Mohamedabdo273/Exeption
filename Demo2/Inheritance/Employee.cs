using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee : Person
    {
        private double salary;
        private string rank;
        private string job;
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }
       
        public double GetSalary()
        {
            return salary;
        }
       
        public void SetRank(string rank)
        {
            this.rank = rank;
        }
       
        public string GetRank()
        {
            return rank;
        }
       
        public void SetJob(string job)
        {
            this.job = job;
        }
        public string GetJob()
        {
            return job;
        }
    }
}
