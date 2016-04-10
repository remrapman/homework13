using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework13
{
    class Person
    {
        private const string InputFile = "Input.txt";
        static List<string> input;
        
        

        public static void CreatePerson()
        {
            input = new List<string>();
            Program.ReadInput();
            Random rand = new Random();
            string NewPerson = new string(input[rand.Next(input.Capacity)]);
            
        }
    }
}
