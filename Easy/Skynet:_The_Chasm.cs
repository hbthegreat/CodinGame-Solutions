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
class Player
{
    static void Main(string[] args)
    {
        int road = int.Parse(Console.ReadLine()); // the length of the road before the gap.
        int gap = int.Parse(Console.ReadLine()); // the length of the gap.
        int platform = int.Parse(Console.ReadLine()); // the length of the landing platform.

        // game loop
        while (true)
        {
            int speed = int.Parse(Console.ReadLine()); // the motorbike's speed.
            int coordX = int.Parse(Console.ReadLine()); // the position on the road of the motorbike.
            
            var command = "";
            if(coordX == road - 1){
                command = "JUMP";
            }else if(coordX < road + gap){
                //Setting speed if needed
                if(speed < gap+1){
                    command = "SPEED";
                }else if(speed > gap+1){
                    command = "SLOW";
                }
                else{
                    command = "WAIT";
                }
            
            } else{
                command = "SLOW";
            }
            
            
            
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(command); // A single line containing one of 4 keywords: SPEED, SLOW, JUMP, WAIT.
        }
    }
}