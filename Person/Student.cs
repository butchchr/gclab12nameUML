using System;
using System.Collections.Generic;
using System.Text;

namespace gclab12nameUML
{
    public class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public Student(string name, string address, string program, int year, double fee) : base (name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public string Program
        {
            get { return program; }
        }

        public int Year
        {
            get { return year; }
        }

        public double Fee
        {
            get { return fee; }
        }

        public override string ToString()
        {
            return ($"Student[Person[name={Name},address={Address}],program={Program},year={Year},fee={Fee}]");
        }
    }
}
