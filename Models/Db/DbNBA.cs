namespace DenchikSportsRu.Models.Db
{
    public class DbNBA
    {
        public string id { get; set; }
        public string club_name { get; set; }
        public string club_photo { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public string conference { get; set; }
        public string club_url { get; set; }
    }
}
