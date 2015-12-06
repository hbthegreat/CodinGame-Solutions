using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<int> powerLevels = new List<int>();
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            powerLevels.Add(pi);
        }
        
        var minDiff = 10000000;
        powerLevels = powerLevels.OrderBy(x => x).ToList();
        for(int i = 0; i< powerLevels.Count() - 1; i++)
        {
            var diff = Math.Abs(powerLevels[i]- powerLevels[i+1]);
            if(diff < minDiff){
                minDiff = diff;
            }
            
            if (minDiff == 1)
            {
                break;
            }
        }
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(minDiff);
    }
}