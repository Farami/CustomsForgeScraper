namespace CustomScraper.Model
{
    public class Song
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Tuning { get; set; }
        public bool Official { get; set; }
        public int CFId { get; set; }
        public bool Lead { get; set; }
        public bool Rhythm { get; set; }
        public bool Bass { get; set; }
        public bool Vocals { get; set; }

        public string GetTitle()
        {
            return string.Format("{3}{0} - {1} ({2})", Artist, Title, Tuning, Official ? "☆ " : "");
        }
    }
}
