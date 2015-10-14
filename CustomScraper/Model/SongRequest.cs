using System.Collections.Generic;

namespace CustomScraper.Model
{
    public class SongRequest
    {
        public SongRequest()
        {
            Results = new List<Song>();
        }

        public enum RequestError
        {
            NoResults,
            TooManyResults
        }

        public bool Error { get; set; }
        public RequestError ErrorType { get; set; }
        public List<Song> Results { get; set; }
    }
}
