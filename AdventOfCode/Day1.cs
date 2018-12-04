using System;
using System.Diagnostics;
using System.IO;

namespace AdventOfCode
{
    class Day1
    {
        static void Main(string[] args)
        {
            bool part1 = true; // Set True to run Part 1
            bool part2 = false; // Set True to run Part 2

            if (part1) {
                string path = @"C:\Users\mogrobin\source\repos\AdventOfCode\AdventOfCode\Day1Input.txt";
                Int32 partOneAnswer = PartOne(path);
                Debug.WriteLine(partOneAnswer);
            }

            if (part2)
            {

            }

            

        }

        static Int32 PartOne(string PathToFile)
        {
            int sum = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(PathToFile);
            while ((line = file.ReadLine()) != null)
            {
                sum += Convert.ToInt32(line);
            }


            return sum;
        }
    }
}
