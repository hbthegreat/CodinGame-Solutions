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
        string MESSAGE = Console.ReadLine();
        
        var messageAsBinaryString = ToBinary(ConvertToByteArray(MESSAGE, Encoding.UTF8));
        
        var messageAsChuckNorris = ToChuckNorris(messageAsBinaryString);
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
       //Console.WriteLine(messageAsBinaryString);
        Console.WriteLine(messageAsChuckNorris);
    }
    
    public static byte[] ConvertToByteArray(string str, Encoding encoding)
    {
        return encoding.GetBytes(str);
    }
    
    public static String ToBinary(Byte[] data)
    {
        return string.Join("", data.Select(theByte => Convert.ToString(theByte, 2).PadLeft(7,'0')));
    }
    
    public static String ToChuckNorris(string binaryString)
    {
        var chuckNorris = "";
       
        int count = 0;
        int prev = '2';
        
        //character = 1
        foreach (char character in  binaryString.ToCharArray()) {
            if (character != prev) {
                for (int j = 0 ; j < count ; j++)
                { 
                    chuckNorris = chuckNorris + "0";
                }
                if (count != 0) 
                {
                    chuckNorris = chuckNorris + " ";
                }
                chuckNorris = chuckNorris + ((character == '0') ? "00 " : "0 ");
                count = 1;
            } else {
                count++;
            }
            prev = character;
        }
        for (int j = 0 ; j < count ; j++){
            chuckNorris = chuckNorris+"0";         
        }
        return chuckNorris;
    }
}
