using System;
using System.Collections.Generic;
using System.Text;

namespace gclab12nameUML
{
    public class Student : Person
    {
        public string Program { get; }
        public int Year { get; }
        public double Fee { get; }

        public Student(string name, string address, string program, int year, double fee) : base (name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }
    }
}
