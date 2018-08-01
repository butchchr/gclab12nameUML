using System;
using System.Collections.Generic;
using System.Text;

namespace gclab12nameUML
{
    public class Staff : Person
    {
        private string school;
        private double pay;

        public Staff(string name, string address, string school, double pay) :base (name, address)
        {
            this.school = school;
            this.pay = pay;
        }

        public string School
        {
            get { return school; }
        }

        public double Pay
        {
            get { return pay; }
        }

        public override string ToString()
        {
            return ($"Staff[Person[name={Name},address={Address}],school={School},pay={Pay}]");
        }
    }
}
