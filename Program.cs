using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace aoc2
{
    class Program
    {
        static void Main(string[] args)
        {

            //lengte regel: 31
            //lengte regel: 11
            int linelenght = 31;
            var row = new char[linelenght];
            int myposition = 0;
            int treecount = 0;
            foreach (string line in File.ReadLines(@"c:\repos\aoc3\input\example.txt"))
            {
                row = line.ToCharArray();
                Console.WriteLine($"{line} position: {position} character: {row[myposition]}");
                myposition += 3;
                myposition %= (linelenght-1);  //als i > 30, begin dan vooraan door er 30 af te  halen (ofwel rest van deling door 30)
                if (row[myposition] == '#') treecount++;  //als je op boom staat dan deze tellen
            }
            Console.WriteLine($"aantal bomen: {treecount}");

        }
    }
}
