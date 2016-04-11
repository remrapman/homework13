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
            ReadInput();
        }

        public static void ReadInput()
        {
            ReaderWritter.Readlines(InputFile, input);
        }
    }
}
