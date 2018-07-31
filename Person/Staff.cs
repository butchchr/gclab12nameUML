using System;
using System.Collections.Generic;
using System.Text;

namespace gclab12nameUML
{
    public class Staff : Person
    {
        private string School { get; }
        private double Pay { get; }

        public Staff(string name, string address, string school, double pay) :base (name, address)
        {
            School = school;
            Pay = pay;
        }

        public override string ToString()
        {
            return Staff ;
        }
    }
}
