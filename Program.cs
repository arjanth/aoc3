using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace aoc3
{
    class Program
    {
        static void Main(string[] args)
        {

            //lengte regel: 31  (terrain)
            //lengte regel: 11  (example)
            int linelength = 31;
            var row = new char[linelength];
            int myposition = 1;
            int treecount = 0;
            foreach (string line in File.ReadLines(@"c:\repos\aoc3\input\terrain.txt"))
            {
                row = line.ToCharArray();
                Console.WriteLine($"{line} position: {myposition} character: {row[myposition-1]}");
                if (row[myposition - 1] == '#') treecount++;  //als je op boom staat dan deze tellen
                
                myposition += 3;
                //myposition %= linelength;  //niet zeker.
                if (myposition > linelength) { myposition -= linelength; }  // als je over de 31 heen gaan, dan vooraan beginnen.
                
            }
            Console.WriteLine($"aantal bomen: {treecount}");  //goede antwoord: 257

        }
    }
}
