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
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        List<string> Lines = new List<string>();
        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();
            Lines.Add(ROW);
        }
        
        var standardInput = T.ToUpper();
        var outputString = "";
        foreach(var line in Lines){
            for(int i = 0; i < standardInput.Length; i++){
                
                if(standardInput[i] > 64 && standardInput[i] < 91){
                    var spot = (standardInput[i]-65)*L;
                    outputString = outputString + line.Substring(spot,L);    
                }
                else{
                    outputString = outputString + line.Substring(L*26,L);
                }
            }
            outputString = outputString + "\n";
        }
       
        
        
        
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(outputString);
    }
}