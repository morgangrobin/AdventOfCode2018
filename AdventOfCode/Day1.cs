using System;
using System.Collections;
using System.Diagnostics;
using System.IO;

namespace AdventOfCode
{
    class Day1
    {
        static void Main(string[] args)
        {
            bool part1 = false; // Set True to run Part 1
            bool part2 = true; // Set True to run Part 2
            string path = @"C:\Users\mogrobin\source\repos\AdventOfCode\AdventOfCode\Day1Input.txt";

            

            if (part1) {
                int partOneAnswer = partOne(path);
                Debug.WriteLine(partOneAnswer);
            }

            if (part2)
            {
                int partTwoAnswer = partTwo(path);
                Debug.WriteLine(partTwoAnswer);
            }



        }

        static int partOne(string pathToFile)
        {
            int sum = 0;
            string line;
            StreamReader file = initReader(pathToFile);
            while ((line = file.ReadLine()) != null)
            {
                sum += Convert.ToInt32(line);
            }


            return sum;
        }

        static int partTwo(string pathToFile)
        {
            Hashtable checkDupes = new Hashtable();
            string[] lines = File.ReadAllLines(pathToFile);

            int iterator = 0;
            int sum = 0;
            while (true)
            {
                sum += int.Parse(lines[iterator]);
                try
                {
                    checkDupes.Add(sum, sum);
                }
                catch
                {
                    return sum;
                }

                iterator += 1;
                iterator = iterator % lines.Length;
            }

            return -1;
        }

        static StreamReader initReader(string pathToFile)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(pathToFile);
            return file;
        }
    }
}
