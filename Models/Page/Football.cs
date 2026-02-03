using DenchikSportsRu.Models.Db;

namespace DenchikSportsRu.Models.Page
{
    public class Football
    {
        public List<DbFootball> List { get; set; }
        public int id { get; set; }
        public string league_url { get; set; }
        public string leaguetop { get; set; }

        public string league_news { get; set; }
        public string league_photo { get; set; }
        public string league_img { get; set; }

    }
}
