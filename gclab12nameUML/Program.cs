using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gclab12nameUML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>();
            
            People.Add(new Student("Brad Bradson", "120 Bradford", "Brewmastering", 4, 1200));
            People.Add(new Staff("Ross Rossson", "230 Rossford", "Hill Middle", 45000));

            foreach (Person them in People)
            {
                Console.WriteLine(them.ToString());
            }

            Console.ReadKey();
        }
    }
}
