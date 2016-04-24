using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework13
{
    public class Person
    {
        private List<string> input;
        public Person(List<string> inputlist)
        {
            input = inputlist;
        }



        public static string CreatePerson()
        {
            List<string> input = Program.ReadInput();
            Random rand = new Random();
            string NewPerson = input[rand.Next(input.Count)];
            return NewPerson;
        }
    }
}
