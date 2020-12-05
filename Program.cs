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
            int myposition = 1;   //positie begint gewoon bij 1. zoals in de som
            int treecount = 0;
            int right = 1;  //aantal stappen naar rechts   bij deel1 right = 3
            int down = 2;    //aantal stappen naar beneden. bij deel1 down=1     
            int downcount = 1;  //houdt aantal stappen bij dat down is gezet. de eerste regel moet altijd geteld worden daarom initialisatie op 1
            foreach (string line in File.ReadLines(@"c:\repos\aoc3\input\terrain.txt"))
            {
                row = line.ToCharArray();
                downcount++;
                if (downcount < down) { continue; } else { downcount = 0; }  //zorg dat regels worden overgeslagen bij down groter dan 1

                Console.WriteLine($"{line} position: {myposition} character: {row[myposition-1]}");
                if (row[myposition - 1] == '#') treecount++;  //als je op boom staat dan deze tellen

                
                myposition += right;
                if (myposition > linelength) { myposition -= linelength; }  // als je over de 31 heen gaan, dan vooraan beginnen.

                

            }
            Console.WriteLine($"aantal bomen: {treecount}");  //goede antwoord: op deel 1= 257

            // goede antwoord op deel 2: 61 * 257 * 64 * 47 * 37 = 1744787392



        }
    }
}
