using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = @"C:\d\ff.txt";
            using (StreamWriter stream = new StreamWriter(path))
            {
                stream.WriteLine("Nikolai");
                stream.WriteLine("Petrenkov");
                stream.WriteLine("17");
            }
        }
    }
}
