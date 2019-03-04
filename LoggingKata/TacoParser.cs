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
            logger.LogInfo("Begin parsing");

            var cells = line.Split(',');

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
            // parse your string as a `double`
            double lat = double.Parse(latitude);
            double lon = double.Parse(longitude);

            // New instance of the TacoBell class
            TacoBell tacoBell = new TacoBell();

            tacoBell.Name = name;

            Point point = new Point();
            point.Latitude = lat;
            point.Longitude = lon;

            tacoBell.Location = point;

            return tacoBell;



        }
    }
}