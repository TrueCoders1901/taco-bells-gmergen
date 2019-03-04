using System;
using System.Linq;
using System.IO;
using GeoCoordinatePortable;

namespace LoggingKata
{
    class Program
    {
        static readonly ILog logger = new TacoLogger();
        const string csvPath = "TacoBell-US-AL.csv";

        static void Main(string[] args)
        {
            logger.LogInfo("Log initialized");

            var lines = File.ReadAllLines(csvPath);

            logger.LogInfo($"Lines: {lines[0]}");

            var parser = new TacoParser();

            var locations = lines.Select(parser.Parse).ToArray();

            ITrackable locA = null;
            ITrackable locB = null;
            ITrackable locX = null;
            ITrackable locY = null;

            double distance = 0;

            for (int i = 0; i < locations.Length; i++)
            {
                locA = locations[i];
                GeoCoordinate CorA = new GeoCoordinate(locA.Location.Latitude, locA.Location.Longitude);

                for (int x = i + 1; x < locations.Length; x++)
                {
                    locB = locations[x];
                    GeoCoordinate CorB = new GeoCoordinate(locB.Location.Latitude, locB.Location.Longitude);

                    double currentDistance = CorA.GetDistanceTo(CorB);

                    if(currentDistance > distance)
                    {
                        distance = currentDistance;
                        locX = locA;
                        locY = locB;
                    }
                }
            }

            Console.WriteLine(locX.Name + locX.Location + locY.Name + locY.Location + distance);
            Console.ReadLine();
           
        }
    }
}