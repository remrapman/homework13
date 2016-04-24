using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework13
{
    class Program
    {
        private const string InputFile = "Input.txt";
        private const string WhiteListFile = "Whitelist.txt";
        private const string BlackListFile = "Blacklist.txt";
        private const string OutputBlack = "Output_blacklist.txt";
        private const string OutputWhite = "Output_whitelist.txt";
        private const string OutputBoth = "Output_black_and_white.txt";

        static List<string> input;
        static List<string> black;
        static List<string> white;
        static HashSet<string> forwritting;
        static List<string> forfilter;
        
        static void Main(string[] args)
        {
            input = new List<string>();
            black = new List<string>();
            white = new List<string>();
            forwritting = new HashSet<string>();
            forfilter = new List<string>();

            //string NewPerson = Person.CreatePerson();
            PersonGeneretor.Generate();
            Console.ReadLine();
        }

        public static List<string> ReadInput()
        {
            ReaderWritter.Readlines(InputFile, input);
            return input;
        }

        
    }
}
