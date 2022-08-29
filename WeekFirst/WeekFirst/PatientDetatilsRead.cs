using System;
using System.IO;

namespace WeekFirst
{
    class PatientDetatilsRead
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("C://Users/RRagini/source/repos/WeekFirst.CSV", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            string line = s.ReadLine();
            Console.WriteLine(line);

            s.Close();
            f.Close();
        }
    }
}