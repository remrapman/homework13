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
        public static void ReadInput()
        {
            Readlines(InputFile, input);
        }

        private static void Readlines(string path, List<string> list)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
        }

        private static void Writelines(string outpath, List<string> list)
        {
            using (StreamWriter writer = new StreamWriter(outpath))
            {
                foreach (string line in list)
                {
                    writer.WriteLine(line);
                }
           }
        }


    }
}
