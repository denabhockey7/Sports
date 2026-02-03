using DenchikSportsRu.Models.Db;

namespace DenchikSportsRu.Models.Page
{
    public class Leagueother
    {
        public List<DbLeagueother> List { get; set; }
        public int id { get; set; }
        public string league_url { get; set; }

        public string league_name { get; set; }
        public string league_name2 { get; set; }
        public string league_photo { get; set; }
        public string league_img { get; set; }
    }
}
