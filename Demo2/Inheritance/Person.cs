using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Person
    {
        private string name;
        private int age;
        private string address;
        private string nationalty;
        public void SetName(int age)
        {
            this.age = age;
        }
        public int GetAge() { return this.age; }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public string GetAddress() { return this.address; }
        public void SetNationalty(string nationalty)
        {
            this.nationalty = nationalty;
        }
        public string GetNationalty() { return this.nationalty; }
        
    }
}
