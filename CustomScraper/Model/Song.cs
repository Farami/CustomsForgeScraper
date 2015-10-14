namespace CustomScraper.Model
{
    public class Song
    {
        private const string DOWNLOAD_BASE = "http://customsforge.com/process.php?id=";
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Tuning { get; set; }
        public bool Official { get; set; }
        public int CFId { get; set; }
        public bool Lead { get; set; }
        public bool Rhythm { get; set; }
        public bool Bass { get; set; }
        public bool Vocals { get; set; }

        /// <summary>
        /// Gets a formatted song title.
        /// </summary>
        /// <returns>Artist - Title (Tuning); has a star in front if official.</returns>
        public string GetTitle()
        {
            return string.Format("{3}{0} - {1} ({2})", Artist, Title, Tuning, Official ? "☆ " : "");
        }

        /// <summary>
        /// Gets a download link for the song.
        /// </summary>
        /// <returns>Returns the CustomsForge download link.</returns>
        public string GetDownloadLink()
        {
            return DOWNLOAD_BASE + CFId.ToString();
        }
    }
}
