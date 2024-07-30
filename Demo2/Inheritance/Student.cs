using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Student : Person
    {
        private string studyLevel;
        private string specialization;
        private double gpa;
        public void SetStudyLevel(string studyLevel)
        {
            this.studyLevel = studyLevel;
        }
        public string GetStudyLevel()
        {
            return  studyLevel;
        }
       
        public void SetSpecialization(string specialization)
        {
            this.specialization = specialization;
        }
        
        public string GetSpecialization()
        {
            return specialization;
        }
        public void SetGpa(double gpa)
        {
            this.gpa = gpa;
        }
        public double GetGpa()
        {
            return gpa;
        }
    }
}
