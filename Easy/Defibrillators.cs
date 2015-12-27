using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string LON = Console.ReadLine();
        string LAT = Console.ReadLine();
        int N = int.Parse(Console.ReadLine());
        List<string> DEFIBs = new List<string>();
        for (int i = 0; i < N; i++)
        {
            string DEFIB = Console.ReadLine();
            DEFIBs.Add(DEFIB);
        }
        
        var baseDistance = double.PositiveInfinity;
        var centreName = "";
        
        foreach(var defib in DEFIBs){
            var data = defib.Split(';');
            var nameOfCentre = data[1];
            var lng = float.Parse(data[4].Replace(',','.'), CultureInfo.InvariantCulture.NumberFormat);
            var lat = float.Parse(data[5].Replace(',','.'), CultureInfo.InvariantCulture.NumberFormat);
            var userLng = float.Parse(LON.Replace(',','.'), CultureInfo.InvariantCulture.NumberFormat);
            var userLat =float.Parse(LAT.Replace(',','.'), CultureInfo.InvariantCulture.NumberFormat);
            
            //Formulas
            var x = (userLng-lng) * Math.Cos((lat + userLat)/2);
            var y = (userLat-lat);
            var d = Math.Sqrt(x*x+y*y) * 6371;
            
            if(d < baseDistance){
                baseDistance = d;
                centreName = nameOfCentre;
            }
        }
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(centreName);
    }
}
