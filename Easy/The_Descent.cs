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

        // game loop
        while (true)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int SX = int.Parse(inputs[0]);
            int SY = int.Parse(inputs[1]);
            var currentHeighestMountain = 10;
            var currentHeighestHeight = 0;
            var order = "empty";
            for (int i = 0; i < 8; i++)
            {
                int MH = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.
                if(MH > currentHeighestHeight){
                    currentHeighestHeight =MH;
                    currentHeighestMountain = i;
                }
                if(currentHeighestMountain == SX){
                    order ="FIRE";
                }
                else{
                    order ="HOLD";
                }
            }
            Console.WriteLine(order); // either:  FIRE (ship is firing its phase cannons) or HOLD (ship is not firing).
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
        }
    }
}