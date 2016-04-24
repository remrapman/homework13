using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace homework13
{


    public class PersonGeneretor
    {
        private string GenName;
        Timer timer = new Timer();

        public static void Generate()//string name)
        {
            //GenName = name;
            string NewPerson = Person.CreatePerson();
            //timer.Interval = 2000;
            Console.WriteLine("Hi my name is {0}", NewPerson);

        }

    }
}
