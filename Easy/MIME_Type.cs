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
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        List<string> files = new List<string>();
        Dictionary<string,string> mimeTypes = new Dictionary<string,string>();
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string EXT = inputs[0]; // file extension
            string MT = inputs[1]; // MIME type.
            mimeTypes.Add(EXT.ToLower(),MT);
        }
        for (int i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine(); // One file name per line.
            files.Add(FNAME);
        }
        
        foreach(string file in files){
            var dotPosition = file.LastIndexOf(".");
            var extension = file.Substring(dotPosition+1).ToLower();
            
            if(dotPosition == -1){
                Console.WriteLine("UNKNOWN");
            }
            else{
                if(mimeTypes.ContainsKey(extension)){
                    Console.WriteLine(mimeTypes.FirstOrDefault(x => x.Key == extension).Value);
                }else
                {
                    Console.WriteLine("UNKNOWN");
                }
            }
        }
            
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        //Console.WriteLine("UNKNOWN"); // For each of the Q filenames, display on a line the corresponding MIME type. If there is no corresponding type, then display UNKNOWN.
    }
}