using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_BaseLogic.Class
{
    public class Person
    {
        public string name { get; set; }
        public bool hasDrivingLicense { get; set; }
    }
    public class Car
    {
        public double speed { get; set; }
        public String vehicleType { get; set; }
        public Person driver { get; set; }
    }
}
