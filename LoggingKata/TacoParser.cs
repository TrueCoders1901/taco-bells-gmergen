namespace LoggingKata


{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();


        public ITrackable Parse(string line)
        {
            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                return null;
            }

            // grab the latitude from your array at index 0
            string latitude = cells[0];


            // grab the longitude from your array at index 1
            string longitude = cells[1];

            // grab the name from your array at index 2
            string name = cells[2];

            // Your going to need to parse your string as a `double`
            double lat = double.Parse(latitude);
            double lon = double.Parse(longitude);
            // which is similar to parsing a string as an `int`

            // You'll need to create a TacoBell class
            // that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class
            TacoBell tacoBell = new TacoBell();
            // With the name and point set correctly
            tacoBell.Name = name;

            Point point = new Point();
            point.Latitude = lat;
            point.Longitude = lon;


            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable
            return tacoBell;

            


        }
    }
}