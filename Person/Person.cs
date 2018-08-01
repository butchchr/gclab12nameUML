using System;

namespace gclab12nameUML
{
    public class Person
    {
        private string name;
        private string address;

        public Person (string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string Name 
        {
            get { return name; }
        }

        public string Address
        {
            get { return address; }
        }

        public override string ToString()
        {
            return ($"Person[name={name},address={address}]");
        }
    }
}
