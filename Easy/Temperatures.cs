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
        int N = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string TEMPS = Console.ReadLine(); // the N temperatures expressed as integers ranging from -273 to 5526
        
        var result = "";
        if(N == 0){
            result = "0";
        }else{
            string[] TEMPSSPLIT = TEMPS.Split(' ');
            var closest = Convert.ToInt32(TEMPSSPLIT[0]);
            for(int i =0; i<N; i++){
                if(Math.Abs(Convert.ToInt32(TEMPSSPLIT[i]))<Math.Abs(closest))
                {
                    closest = Convert.ToInt32(TEMPSSPLIT[i]);
                }else if(Math.Abs(Convert.ToInt32(TEMPSSPLIT[i]))==Math.Abs(closest))
                {
                    if(closest<Convert.ToInt32(TEMPSSPLIT[i]))
                    {
                        closest = Convert.ToInt32(TEMPSSPLIT[i]);
                    }
                }
            }
            result = closest+"";
        }
        
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(result);
    }
}