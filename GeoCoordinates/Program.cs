using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace GeoCoordinates
{
   class Program
   {/// <summary>
   /// have 2 earth coordiantes using longitude and lattiude
   /// calculate their distance
   /// use class GeoCode in namespace System.Device
   /// </summary>
   /// <param name="args"></param>
      static void Main(string[] args)
      {
         var sCoord = new GeoCoordinate(34.7818, 32.0853); //coordinate of tel avivi
         var eCoord = new GeoCoordinate(35.2137, 31.7683); //coordinate of jerusalem

         var distance =  sCoord.GetDistanceTo(eCoord);
         Console.WriteLine($"your distance is {distance} meters");

      }
   }
}
